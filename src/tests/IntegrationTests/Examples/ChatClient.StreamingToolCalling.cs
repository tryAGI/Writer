/*
order: 40
title: Chat Client Streaming Tool Calling
slug: chat-client-streaming-tool-calling
*/

using System.ComponentModel;
using Meai = Microsoft.Extensions.AI;

namespace Writer.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ChatClient_StreamingToolCalling()
    {
        using var client = GetAuthenticatedClient();
        Meai.IChatClient chatClient = client;

        //// Stream chat responses with tool calling using the MEAI IChatClient interface.
        //// Define a simple tool that returns the current weather.
        var tool = Meai.AIFunctionFactory.Create(
            (string location) => $"The weather in {location} is sunny, 72°F.",
            "get_weather",
            "Gets the current weather for a location.");

        var enumerable = chatClient.GetStreamingResponseAsync(
            messages: [new Meai.ChatMessage(Meai.ChatRole.User, "What's the weather in San Francisco?")],
            new Meai.ChatOptions
            {
                ModelId = "palmyra-x-004",
                Tools = [tool],
            });

        var hasContent = false;
        Meai.ChatFinishReason? finishReason = null;
        await foreach (var update in enumerable)
        {
            if (update.Text is { Length: > 0 })
            {
                Console.Write(update.Text);
                hasContent = true;
            }

            if (update.FinishReason is not null)
            {
                finishReason = update.FinishReason;
            }
        }

        //// The model should either respond with tool calls or text content.
        (hasContent || finishReason == Meai.ChatFinishReason.ToolCalls).Should().BeTrue();
    }
}
