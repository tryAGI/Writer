#nullable enable

namespace Writer.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebSearchRequestTimeRangeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Writer.WebSearchRequestTimeRange>
    {
        /// <inheritdoc />
        public override global::Writer.WebSearchRequestTimeRange Read(
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
                        return global::Writer.WebSearchRequestTimeRangeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Writer.WebSearchRequestTimeRange)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Writer.WebSearchRequestTimeRange);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Writer.WebSearchRequestTimeRange value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Writer.WebSearchRequestTimeRangeExtensions.ToValueString(value));
        }
    }
}
