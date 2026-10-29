
#nullable enable

namespace Writer
{
    /// <summary>
    ///
    /// </summary>
    public enum ToolDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Function,
        /// <summary>
        ///
        /// </summary>
        Graph,
        /// <summary>
        ///
        /// </summary>
        Llm,
        /// <summary>
        ///
        /// </summary>
        WebSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolDiscriminatorType value)
        {
            return value switch
            {
                ToolDiscriminatorType.Function => "function",
                ToolDiscriminatorType.Graph => "graph",
                ToolDiscriminatorType.Llm => "llm",
                ToolDiscriminatorType.WebSearch => "web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "function" => ToolDiscriminatorType.Function,
                "graph" => ToolDiscriminatorType.Graph,
                "llm" => ToolDiscriminatorType.Llm,
                "web_search" => ToolDiscriminatorType.WebSearch,
                _ => null,
            };
        }
    }
}