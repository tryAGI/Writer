#nullable enable

using System.Runtime.CompilerServices;
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

        await foreach (var chunks in GenerationApi.ChatAsStreamAsync(request, cancellationToken: cancellationToken).ConfigureAwait(false))
        {
            foreach (var chunk in chunks)
            {
                if (chunk.Choices is not { Count: > 0 })
                {
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

                    if (delta.ToolCalls is { Count: > 0 })
                    {
                        foreach (var toolCall in delta.ToolCalls)
                        {
                            update.Contents.Add(new Meai.FunctionCallContent(
                                toolCall.Id ?? string.Empty,
                                toolCall.Function?.Name ?? string.Empty,
                                arguments: null)
                            {
                                RawRepresentation = toolCall,
                            });
                        }
                    }

                    if (choice.FinishReason is { } finishReason)
                    {
                        update.FinishReason = finishReason switch
                        {
                            ChatCompletionFinishReason.Stop => Meai.ChatFinishReason.Stop,
                            ChatCompletionFinishReason.Length => Meai.ChatFinishReason.Length,
                            ChatCompletionFinishReason.ToolCalls => Meai.ChatFinishReason.ToolCalls,
                            _ => null,
                        };
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
