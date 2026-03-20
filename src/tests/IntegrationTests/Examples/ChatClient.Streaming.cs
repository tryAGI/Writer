/*
order: 30
title: Chat Client Streaming
slug: chat-client-streaming
*/

using Meai = Microsoft.Extensions.AI;

namespace Writer.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ChatClient_Streaming()
    {
        using var client = GetAuthenticatedClient();
        Meai.IChatClient chatClient = client;

        //// Stream chat responses using the MEAI IChatClient interface.
        var enumerable = chatClient.GetStreamingResponseAsync(
            messages: [new Meai.ChatMessage(Meai.ChatRole.User, "Generate 5 random words.")],
            new Meai.ChatOptions
            {
                ModelId = "palmyra-x-004",
            });

        var deltas = new List<string>();
        await foreach (var update in enumerable)
        {
            Console.Write(update.Text);
            deltas.Add(update.Text ?? string.Empty);
        }

        deltas.Should().NotBeEmpty();
    }
}
