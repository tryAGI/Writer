# CLAUDE.md — Writer SDK

## Overview

Auto-generated C# SDK for [Writer](https://writer.com/) — enterprise AI platform for chat completions, knowledge graphs, files, applications/agents, vision, translation, and AI tools.

## Build & Test

```bash
dotnet build Writer.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Bearer token auth with Writer API key:

```csharp
var client = new WriterClient(apiKey); // WRITER_API_KEY env var
```

## Key Files

- `src/libs/Writer/generate.sh` — Regeneration script (downloads Stainless-hosted spec, runs autosdk)
- `src/libs/Writer/Generated/` — **Never edit** — auto-generated code
- `src/libs/Writer/Extensions/WriterClient.ChatClient.cs` — MEAI `IChatClient` implementation
- `src/tests/IntegrationTests/Tests.cs` — Test helper with bearer auth
- `src/tests/IntegrationTests/Examples/` — Example tests (also generate docs)

## MEAI Integration

- **Interface:** `IChatClient` (text, streaming, tool calling)
- **Namespace conflict:** Yes — Writer namespace has own `ChatMessage`/`ChatResponse` types
- **Pattern:** Uses `using Meai = Microsoft.Extensions.AI;` alias throughout
- **Sub-client delegation:** `WriterClient.GenerationApi.ChatAsync()` / `ChatAsStreamAsync()`
- **Tool support:** Maps `AIFunction` → `FunctionTool`, supports `AutoChatToolMode` and `RequiredChatToolMode`

## NuGet

- **PackageId:** `tryAGI.Writer` (bare name taken on NuGet)
