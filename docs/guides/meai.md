# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The Writer SDK implements `IChatClient` from [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai), providing a unified interface for chat completions with text, streaming, and tool calling support.

## Installation

```bash
dotnet add package tryAGI.Writer
```

## Namespace Note

The Writer SDK has its own `ChatMessage` and `ChatResponse` types that conflict with `Microsoft.Extensions.AI`. Use the `Meai` alias:

```csharp
using Meai = Microsoft.Extensions.AI;
```

## Chat Completions

`WriterClient` implements `IChatClient`, so you can use it with the standard MEAI interface.

```csharp
using Writer;
using Meai = Microsoft.Extensions.AI;

Meai.IChatClient client = new WriterClient(apiKey: Environment.GetEnvironmentVariable("WRITER_API_KEY")!);

var response = await client.GetResponseAsync(
    "What is the capital of France?",
    new Meai.ChatOptions { ModelId = "palmyra-x-004" });

Console.WriteLine(response.Text);
```

## Streaming

```csharp
using Writer;
using Meai = Microsoft.Extensions.AI;

Meai.IChatClient client = new WriterClient(apiKey: Environment.GetEnvironmentVariable("WRITER_API_KEY")!);

await foreach (var update in client.GetStreamingResponseAsync(
    "Explain quantum computing in simple terms.",
    new Meai.ChatOptions { ModelId = "palmyra-x-004" }))
{
    Console.Write(update.Text);
}
```

## Tool Calling

```csharp
using Writer;
using Meai = Microsoft.Extensions.AI;

Meai.IChatClient client = new WriterClient(apiKey: Environment.GetEnvironmentVariable("WRITER_API_KEY")!);

var tool = Meai.AIFunctionFactory.Create(
    (string location) => $"The weather in {location} is sunny, 22C.",
    "GetWeather",
    "Gets the current weather for a given location.");

var options = new Meai.ChatOptions
{
    ModelId = "palmyra-x-004",
    Tools = [tool],
};

var messages = new List<Meai.ChatMessage>
{
    new(Meai.ChatRole.User, "What is the weather in London?"),
};

while (true)
{
    var response = await client.GetResponseAsync(messages, options);
    messages.AddRange(response.ToChatMessages());

    if (response.FinishReason == Meai.ChatFinishReason.ToolCalls)
    {
        var results = await response.CallToolsAsync(options);
        messages.AddRange(results);
        continue;
    }

    Console.WriteLine(response.Text);
    break;
}
```

## Dependency Injection

```csharp
using Writer;
using Meai = Microsoft.Extensions.AI;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<Meai.IChatClient>(
    new WriterClient(apiKey: builder.Configuration["Writer:ApiKey"]!));
```

## Provider Metadata

```csharp
var metadata = Meai.ChatClientExtensions.GetService<Meai.ChatClientMetadata>(client);
Console.WriteLine($"Provider: {metadata?.ProviderName}"); // "WriterClient"
Console.WriteLine($"Endpoint: {metadata?.ProviderUri}");
```
