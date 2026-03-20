
#nullable enable

namespace Writer
{
    /// <summary>
    /// Type of input field determining its behavior and validation rules.
    /// </summary>
    public enum ApplicationInputType
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Dropdown,
        /// <summary>
        /// 
        /// </summary>
        File,
        /// <summary>
        /// 
        /// </summary>
        Media,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApplicationInputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApplicationInputType value)
        {
            return value switch
            {
                ApplicationInputType.Text => "text",
                ApplicationInputType.Dropdown => "dropdown",
                ApplicationInputType.File => "file",
                ApplicationInputType.Media => "media",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApplicationInputType? ToEnum(string value)
        {
            return value switch
            {
                "text" => ApplicationInputType.Text,
                "dropdown" => ApplicationInputType.Dropdown,
                "file" => ApplicationInputType.File,
                "media" => ApplicationInputType.Media,
                _ => null,
            };
        }
    }
}