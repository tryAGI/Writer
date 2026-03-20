
#nullable enable

namespace Writer
{
    /// <summary>
    /// Controls search comprehensiveness:<br/>
    /// - `basic`: Returns fewer but highly relevant results<br/>
    /// - `advanced`: Performs a deeper search with more results<br/>
    /// Default Value: basic
    /// </summary>
    public enum WebSearchRequestSearchDepth
    {
        /// <summary>
        /// Returns fewer but highly relevant results
        /// </summary>
        Basic,
        /// <summary>
        /// Performs a deeper search with more results
        /// </summary>
        Advanced,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebSearchRequestSearchDepthExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSearchRequestSearchDepth value)
        {
            return value switch
            {
                WebSearchRequestSearchDepth.Basic => "basic",
                WebSearchRequestSearchDepth.Advanced => "advanced",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSearchRequestSearchDepth? ToEnum(string value)
        {
            return value switch
            {
                "basic" => WebSearchRequestSearchDepth.Basic,
                "advanced" => WebSearchRequestSearchDepth.Advanced,
                _ => null,
            };
        }
    }
}