#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Writer.JsonConverters
{
    /// <inheritdoc />
    public class ApplicationInputOptionsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Writer.ApplicationInputOptions>
    {
        /// <inheritdoc />
        public override global::Writer.ApplicationInputOptions Read(
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
            if (__jsonProps.Contains("list")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("max_files")) __score1++;
            if (__jsonProps.Contains("file_types")) __score1++;
            if (__jsonProps.Contains("max_word_count")) __score1++;
            if (__jsonProps.Contains("max_file_size_mb")) __score1++;
            if (__jsonProps.Contains("upload_types")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("file_types")) __score2++;
            if (__jsonProps.Contains("max_image_size_mb")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("max_fields")) __score3++;
            if (__jsonProps.Contains("min_fields")) __score3++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }

            global::Writer.ApplicationInputDropdownOptions? dropdown = default;
            global::Writer.ApplicationInputFileOptions? file = default;
            global::Writer.ApplicationInputMediaOptions? media = default;
            global::Writer.ApplicationInputTextOptions? text = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Writer.ApplicationInputDropdownOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Writer.ApplicationInputDropdownOptions> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Writer.ApplicationInputDropdownOptions).Name}");
                        dropdown = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Writer.ApplicationInputFileOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Writer.ApplicationInputFileOptions> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Writer.ApplicationInputFileOptions).Name}");
                        file = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Writer.ApplicationInputMediaOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Writer.ApplicationInputMediaOptions> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Writer.ApplicationInputMediaOptions).Name}");
                        media = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Writer.ApplicationInputTextOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Writer.ApplicationInputTextOptions> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Writer.ApplicationInputTextOptions).Name}");
                        text = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (dropdown == null && file == null && media == null && text == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Writer.ApplicationInputDropdownOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Writer.ApplicationInputDropdownOptions> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Writer.ApplicationInputDropdownOptions).Name}");
                    dropdown = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Writer.ApplicationInputFileOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Writer.ApplicationInputFileOptions> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Writer.ApplicationInputFileOptions).Name}");
                    file = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Writer.ApplicationInputMediaOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Writer.ApplicationInputMediaOptions> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Writer.ApplicationInputMediaOptions).Name}");
                    media = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Writer.ApplicationInputTextOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Writer.ApplicationInputTextOptions> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Writer.ApplicationInputTextOptions).Name}");
                    text = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Writer.ApplicationInputOptions(
                dropdown,

                file,

                media,

                text
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Writer.ApplicationInputOptions value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsDropdown)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Writer.ApplicationInputDropdownOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Writer.ApplicationInputDropdownOptions?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Writer.ApplicationInputDropdownOptions).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Dropdown, typeInfo);
            }
            else if (value.IsFile)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Writer.ApplicationInputFileOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Writer.ApplicationInputFileOptions?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Writer.ApplicationInputFileOptions).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.File, typeInfo);
            }
            else if (value.IsMedia)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Writer.ApplicationInputMediaOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Writer.ApplicationInputMediaOptions?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Writer.ApplicationInputMediaOptions).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Media, typeInfo);
            }
            else if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Writer.ApplicationInputTextOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Writer.ApplicationInputTextOptions?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Writer.ApplicationInputTextOptions).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeInfo);
            }
        }
    }
}