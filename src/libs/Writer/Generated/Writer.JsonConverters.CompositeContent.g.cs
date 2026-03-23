#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Writer.JsonConverters
{
    /// <inheritdoc />
    public class CompositeContentJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Writer.CompositeContent>
    {
        /// <inheritdoc />
        public override global::Writer.CompositeContent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("text")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("image_url")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Writer.TextFragment? text = default;
            global::Writer.ImageFragment? image = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Writer.TextFragment), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Writer.TextFragment> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Writer.TextFragment).Name}");
                        text = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Writer.ImageFragment), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Writer.ImageFragment> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Writer.ImageFragment).Name}");
                        image = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (text == null && image == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Writer.TextFragment), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Writer.TextFragment> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Writer.TextFragment).Name}");
                    text = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Writer.ImageFragment), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Writer.ImageFragment> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Writer.ImageFragment).Name}");
                    image = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Writer.CompositeContent(
                text,

                image
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Writer.CompositeContent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Writer.TextFragment), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Writer.TextFragment?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Writer.TextFragment).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeInfo);
            }
            else if (value.IsImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Writer.ImageFragment), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Writer.ImageFragment?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Writer.ImageFragment).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image, typeInfo);
            }
        }
    }
}