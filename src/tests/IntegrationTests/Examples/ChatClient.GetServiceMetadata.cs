/*
order: 40
title: Chat Client Get Service Metadata
slug: chat-client-get-service-metadata
*/

using Meai = Microsoft.Extensions.AI;

namespace Writer.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void ChatClient_GetService_Metadata()
    {
        using var client = new WriterClient("test-api-key");
        Meai.IChatClient chatClient = client;

        //// Retrieve metadata about the chat provider.
        var metadata = Meai.ChatClientExtensions.GetService<Meai.ChatClientMetadata>(chatClient);

        metadata.Should().NotBeNull();
        metadata!.ProviderName.Should().Be(nameof(WriterClient));
    }
}
