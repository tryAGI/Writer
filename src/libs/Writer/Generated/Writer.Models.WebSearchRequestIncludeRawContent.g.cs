
#nullable enable

namespace Writer
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebSearchRequestIncludeRawContent
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Markdown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebSearchRequestIncludeRawContentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSearchRequestIncludeRawContent value)
        {
            return value switch
            {
                WebSearchRequestIncludeRawContent.Text => "text",
                WebSearchRequestIncludeRawContent.Markdown => "markdown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSearchRequestIncludeRawContent? ToEnum(string value)
        {
            return value switch
            {
                "text" => WebSearchRequestIncludeRawContent.Text,
                "markdown" => WebSearchRequestIncludeRawContent.Markdown,
                _ => null,
            };
        }
    }
}