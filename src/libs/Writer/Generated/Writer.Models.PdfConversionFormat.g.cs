
#nullable enable

namespace Writer
{
    /// <summary>
    /// The format into which the PDF content should be converted.
    /// </summary>
    public enum PdfConversionFormat
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
    public static class PdfConversionFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PdfConversionFormat value)
        {
            return value switch
            {
                PdfConversionFormat.Text => "text",
                PdfConversionFormat.Markdown => "markdown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PdfConversionFormat? ToEnum(string value)
        {
            return value switch
            {
                "text" => PdfConversionFormat.Text,
                "markdown" => PdfConversionFormat.Markdown,
                _ => null,
            };
        }
    }
}