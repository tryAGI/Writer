#nullable enable

namespace Writer.JsonConverters
{
    /// <inheritdoc />
    public sealed class FindGraphsWithFileStatusOrderNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Writer.FindGraphsWithFileStatusOrder?>
    {
        /// <inheritdoc />
        public override global::Writer.FindGraphsWithFileStatusOrder? Read(
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
                        return global::Writer.FindGraphsWithFileStatusOrderExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Writer.FindGraphsWithFileStatusOrder)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Writer.FindGraphsWithFileStatusOrder?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Writer.FindGraphsWithFileStatusOrder? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Writer.FindGraphsWithFileStatusOrderExtensions.ToValueString(value.Value));
            }
        }
    }
}
