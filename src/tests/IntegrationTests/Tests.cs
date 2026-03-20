namespace Writer.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static WriterClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("WRITER_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("WRITER_API_KEY environment variable is not found.");

        var client = new WriterClient(apiKey);
        
        return client;
    }
}
