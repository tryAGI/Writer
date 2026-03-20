#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Writer.JsonConverters
{
    /// <inheritdoc />
    public class ToolJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Writer.Tool>
    {
        /// <inheritdoc />
        public override global::Writer.Tool Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Writer.ToolDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Writer.ToolDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Writer.ToolDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Writer.FunctionTool? function = default;
            if (discriminator?.Type == global::Writer.ToolDiscriminatorType.Function)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Writer.FunctionTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Writer.FunctionTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Writer.FunctionTool)}");
                function = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Writer.GraphTool? graph = default;
            if (discriminator?.Type == global::Writer.ToolDiscriminatorType.Graph)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Writer.GraphTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Writer.GraphTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Writer.GraphTool)}");
                graph = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Writer.LlmTool? llm = default;
            if (discriminator?.Type == global::Writer.ToolDiscriminatorType.Llm)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Writer.LlmTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Writer.LlmTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Writer.LlmTool)}");
                llm = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Writer.TranslationTool? translation = default;
            if (discriminator?.Type == global::Writer.ToolDiscriminatorType.Translation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Writer.TranslationTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Writer.TranslationTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Writer.TranslationTool)}");
                translation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Writer.VisionTool? vision = default;
            if (discriminator?.Type == global::Writer.ToolDiscriminatorType.Vision)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Writer.VisionTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Writer.VisionTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Writer.VisionTool)}");
                vision = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Writer.WebSearchTool? webSearch = default;
            if (discriminator?.Type == global::Writer.ToolDiscriminatorType.WebSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Writer.WebSearchTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Writer.WebSearchTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Writer.WebSearchTool)}");
                webSearch = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Writer.Tool(
                discriminator?.Type,
                function,

                graph,

                llm,

                translation,

                vision,

                webSearch
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Writer.Tool value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsFunction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Writer.FunctionTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Writer.FunctionTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Writer.FunctionTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Function, typeInfo);
            }
            else if (value.IsGraph)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Writer.GraphTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Writer.GraphTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Writer.GraphTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Graph, typeInfo);
            }
            else if (value.IsLlm)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Writer.LlmTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Writer.LlmTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Writer.LlmTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Llm, typeInfo);
            }
            else if (value.IsTranslation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Writer.TranslationTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Writer.TranslationTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Writer.TranslationTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Translation, typeInfo);
            }
            else if (value.IsVision)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Writer.VisionTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Writer.VisionTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Writer.VisionTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Vision, typeInfo);
            }
            else if (value.IsWebSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Writer.WebSearchTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Writer.WebSearchTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Writer.WebSearchTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearch, typeInfo);
            }
        }
    }
}