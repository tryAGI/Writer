#nullable enable

using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using Meai = Microsoft.Extensions.AI;

namespace Writer;

public partial class WriterClient : Meai.IChatClient
{
    private Meai.ChatClientMetadata? _metadata;

    /// <inheritdoc />
    object? Meai.IChatClient.GetService(Type? serviceType, object? serviceKey)
    {
        return
            serviceKey is not null ? null :
            serviceType == typeof(Meai.ChatClientMetadata) ? (_metadata ??= new(nameof(WriterClient), BaseUri)) :
            serviceType?.IsInstanceOfType(this) is true ? this :
            null;
    }

    /// <inheritdoc />
    async Task<Meai.ChatResponse> Meai.IChatClient.GetResponseAsync(
        IEnumerable<Meai.ChatMessage> messages, Meai.ChatOptions? options, CancellationToken cancellationToken)
    {
        var request = CreateChatRequest(messages, options);

        var response = await GenerationApi.ChatAsync(request, cancellationToken: cancellationToken).ConfigureAwait(false);

        Meai.ChatMessage responseMessage = new()
        {
            MessageId = response.Id.ToString(),
            Role = Meai.ChatRole.Assistant,
            RawRepresentation = response,
        };

        if (response.Choices is { Count: > 0 })
        {
            var choice = response.Choices[0];
            var message = choice.Message;

            if (message.Content is { Length: > 0 })
            {
                responseMessage.Contents.Add(new Meai.TextContent(message.Content) { RawRepresentation = message });
            }

            if (message.ToolCalls is { Count: > 0 })
            {
                foreach (var toolCall in message.ToolCalls)
                {
                    IDictionary<string, object?>? arguments = null;
                    if (toolCall.Function.Arguments is { Length: > 0 })
                    {
                        arguments = JsonSerializer.Deserialize<Dictionary<string, object?>>(
                            toolCall.Function.Arguments,
                            JsonSerializerContext.Options);
                    }

                    responseMessage.Contents.Add(new Meai.FunctionCallContent(
                        toolCall.Id,
                        toolCall.Function.Name ?? string.Empty,
                        arguments)
                    {
                        RawRepresentation = toolCall,
                    });
                }
            }
        }

        Meai.ChatResponse completion = new(responseMessage)
        {
            RawRepresentation = response,
            ResponseId = response.Id.ToString(),
            ModelId = response.Model,
            FinishReason = response.Choices is { Count: > 0 }
                ? response.Choices[0].FinishReason switch
                {
                    ChatCompletionFinishReason.Stop => Meai.ChatFinishReason.Stop,
                    ChatCompletionFinishReason.Length => Meai.ChatFinishReason.Length,
                    ChatCompletionFinishReason.ToolCalls => Meai.ChatFinishReason.ToolCalls,
                    ChatCompletionFinishReason.ContentFilter => Meai.ChatFinishReason.ContentFilter,
                    _ => null,
                }
                : null,
        };

        if (response.Usage is { } u)
        {
            completion.Usage = new()
            {
                InputTokenCount = u.PromptTokens,
                OutputTokenCount = u.CompletionTokens,
                TotalTokenCount = u.TotalTokens,
            };
        }

        return completion;
    }

    /// <inheritdoc />
    async IAsyncEnumerable<Meai.ChatResponseUpdate> Meai.IChatClient.GetStreamingResponseAsync(
        IEnumerable<Meai.ChatMessage> messages, Meai.ChatOptions? options, [EnumeratorCancellation] CancellationToken cancellationToken)
    {
        var request = CreateChatRequest(messages, options);
        request.StreamOptions ??= new StreamOptions { IncludeUsage = true };

        // Accumulate tool call chunks by index so we can emit complete arguments
        var toolCallBuilders = new Dictionary<int, (string Id, string Name, StringBuilder Args)>();

        await foreach (var chunks in GenerationApi.ChatAsStreamAsync(request, cancellationToken: cancellationToken).ConfigureAwait(false))
        {
            foreach (var chunk in chunks)
            {
                if (chunk.Choices is not { Count: > 0 })
                {
                    // Last chunk with usage only
                    if (chunk.Usage is { } usageOnly)
                    {
                        yield return new Meai.ChatResponseUpdate
                        {
                            ModelId = chunk.Model,
                            Contents = [new Meai.UsageContent(new()
                            {
                                InputTokenCount = usageOnly.PromptTokens,
                                OutputTokenCount = usageOnly.CompletionTokens,
                                TotalTokenCount = usageOnly.TotalTokens,
                            })],
                        };
                    }
                    continue;
                }

                foreach (var choice in chunk.Choices)
                {
                    var delta = choice.Delta;

                    Meai.ChatResponseUpdate update = new()
                    {
                        ResponseId = chunk.Id.ToString(),
                        ModelId = chunk.Model,
                        RawRepresentation = chunk,
                        Role = Meai.ChatRole.Assistant,
                    };

                    if (delta.Content is { Length: > 0 })
                    {
                        update.Contents.Add(new Meai.TextContent(delta.Content) { RawRepresentation = delta });
                    }

                    // Tool call chunks — accumulate arguments by index
                    if (delta.ToolCalls is { Count: > 0 })
                    {
                        foreach (var tc in delta.ToolCalls)
                        {
                            var index = tc.Index;
                            if (!toolCallBuilders.TryGetValue(index, out var builder))
                            {
                                builder = (
                                    Id: tc.Id ?? string.Empty,
                                    Name: tc.Function?.Name ?? string.Empty,
                                    Args: new StringBuilder());
                                toolCallBuilders[index] = builder;
                            }
                            else
                            {
                                if (!string.IsNullOrEmpty(tc.Id))
                                    toolCallBuilders[index] = builder with { Id = tc.Id! };
                                if (!string.IsNullOrEmpty(tc.Function?.Name))
                                    toolCallBuilders[index] = builder with { Name = tc.Function!.Name };
                            }

                            if (!string.IsNullOrEmpty(tc.Function?.Arguments))
                            {
                                toolCallBuilders[index].Args.Append(tc.Function!.Arguments);
                            }
                        }
                    }

                    // Finish reason — emit accumulated tool calls when finished
                    if (choice.FinishReason is { } finishReason)
                    {
                        update.FinishReason = finishReason switch
                        {
                            ChatCompletionFinishReason.Stop => Meai.ChatFinishReason.Stop,
                            ChatCompletionFinishReason.Length => Meai.ChatFinishReason.Length,
                            ChatCompletionFinishReason.ToolCalls => Meai.ChatFinishReason.ToolCalls,
                            ChatCompletionFinishReason.ContentFilter => Meai.ChatFinishReason.ContentFilter,
                            _ => null,
                        };

                        // Emit complete tool calls with fully accumulated arguments
                        foreach (var (_, builder) in toolCallBuilders)
                        {
                            IDictionary<string, object?>? arguments = null;
                            var argsJson = builder.Args.ToString();
                            if (argsJson.Length > 0)
                            {
                                try
                                {
                                    arguments = JsonSerializer.Deserialize<Dictionary<string, object?>>(
                                        argsJson, JsonSerializerContext.Options);
                                }
                                catch (JsonException)
                                {
                                    // Ignore malformed JSON
                                }
                            }

                            update.Contents.Add(new Meai.FunctionCallContent(
                                builder.Id, builder.Name, arguments));
                        }

                        toolCallBuilders.Clear();
                    }

                    if (chunk.Usage is { } u)
                    {
                        update.Contents.Add(new Meai.UsageContent(new()
                        {
                            InputTokenCount = u.PromptTokens,
                            OutputTokenCount = u.CompletionTokens,
                            TotalTokenCount = u.TotalTokens,
                        }));
                    }

                    yield return update;
                }
            }
        }
    }

    private ChatRequest CreateChatRequest(IEnumerable<Meai.ChatMessage> chatMessages, Meai.ChatOptions? options)
    {
        var messages = new List<ChatMessage>();

        foreach (var chatMessage in chatMessages)
        {
            var writerMessage = new ChatMessage
            {
                Role = chatMessage.Role == Meai.ChatRole.System ? ChatMessageRequestRole.System :
                       chatMessage.Role == Meai.ChatRole.Assistant ? ChatMessageRequestRole.Assistant :
                       chatMessage.Role == Meai.ChatRole.Tool ? ChatMessageRequestRole.Tool :
                       ChatMessageRequestRole.User,
            };

            foreach (var content in chatMessage.Contents)
            {
                switch (content)
                {
                    case Meai.TextContent tc:
                        writerMessage.Content = tc.Text;
                        break;

                    case Meai.FunctionCallContent fcc:
                        writerMessage.Role = ChatMessageRequestRole.Assistant;
                        writerMessage.ToolCalls ??= [];
                        writerMessage.ToolCalls.Add(new ToolCall
                        {
                            Id = fcc.CallId,
                            Function = new Function
                            {
                                Name = fcc.Name,
                                Arguments = JsonSerializer.Serialize(
                                    fcc.Arguments,
                                    JsonSerializerContext.Options),
                            },
                        });
                        break;

                    case Meai.FunctionResultContent frc:
                        writerMessage.Role = ChatMessageRequestRole.Tool;
                        writerMessage.ToolCallId = frc.CallId;
                        writerMessage.Content = frc.Result?.ToString() ?? string.Empty;
                        break;
                }
            }

            messages.Add(writerMessage);
        }

        var request = options?.RawRepresentationFactory?.Invoke(this) as ChatRequest;
        if (request is not null)
        {
            request.Model = options?.ModelId ?? string.Empty;
            if (request.Messages is null)
            {
                request.Messages = messages;
            }
            else
            {
                foreach (var message in messages)
                {
                    request.Messages.Add(message);
                }
            }
        }
        else
        {
            request = new ChatRequest
            {
                Model = options?.ModelId ?? string.Empty,
                Messages = messages,
            };
        }

        request.MaxTokens ??= options?.MaxOutputTokens;
        request.Temperature ??= options?.Temperature;
        request.TopP ??= options?.TopP;

        if (options?.StopSequences is { Count: > 0 } stops)
        {
            request.Stop ??= new OneOf<IList<string>, string>(stops.ToList());
        }

        if (options?.Tools is { Count: > 0 } aitools)
        {
            var tools = request.Tools ?? [];
            request.Tools = tools;

            foreach (var tool in aitools)
            {
                if (tool is Meai.AIFunction f)
                {
                    tools.Add(new FunctionTool
                    {
                        Function = new ToolFunction
                        {
                            Name = f.Name,
                            Description = f.Description,
                            Parameters = f.JsonSchema,
                        },
                    });
                }
            }
        }

        request.ToolChoice ??=
            options?.Tools is not { Count: > 0 } ? null :
            options?.ToolMode is Meai.AutoChatToolMode ? new ToolChoice(new StringToolChoice { Value = StringToolChoiceOptions.Auto }) :
            options?.ToolMode is Meai.RequiredChatToolMode r
                ? r.RequiredFunctionName is not null
                    ? new ToolChoice(new JsonObjectToolChoice
                    {
                        Value = new { type = "function", function = new { name = r.RequiredFunctionName } },
                    })
                    : new ToolChoice(new StringToolChoice { Value = StringToolChoiceOptions.Required })
                : (ToolChoice?)null;

        return request;
    }
}
