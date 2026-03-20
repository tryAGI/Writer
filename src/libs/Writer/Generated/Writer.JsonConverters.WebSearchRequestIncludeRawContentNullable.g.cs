#nullable enable

namespace Writer.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebSearchRequestIncludeRawContentNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Writer.WebSearchRequestIncludeRawContent?>
    {
        /// <inheritdoc />
        public override global::Writer.WebSearchRequestIncludeRawContent? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Writer.WebSearchRequestIncludeRawContentExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Writer.WebSearchRequestIncludeRawContent)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Writer.WebSearchRequestIncludeRawContent?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Writer.WebSearchRequestIncludeRawContent? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Writer.WebSearchRequestIncludeRawContentExtensions.ToValueString(value.Value));
            }
        }
    }
}
