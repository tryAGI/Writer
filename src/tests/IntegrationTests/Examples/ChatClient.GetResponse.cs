/*
order: 20
title: Chat Client Get Response
slug: chat-client-get-response
*/

using Meai = Microsoft.Extensions.AI;

namespace Writer.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ChatClient_GetResponse()
    {
        using var client = GetAuthenticatedClient();
        Meai.IChatClient chatClient = client;

        //// Use the MEAI IChatClient interface for chat completions.
        var response = await chatClient.GetResponseAsync(
            messages: [new Meai.ChatMessage(Meai.ChatRole.User, "Generate 5 random words.")],
            new Meai.ChatOptions
            {
                ModelId = "palmyra-x-004",
            });

        Console.WriteLine(response.Text);

        response.Text.Should().NotBeNullOrEmpty();
    }
}
