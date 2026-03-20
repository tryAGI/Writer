
#nullable enable

namespace Writer
{
    /// <summary>
    /// 
    /// </summary>
    public enum StringToolChoiceOptions
    {
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Required,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StringToolChoiceOptionsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StringToolChoiceOptions value)
        {
            return value switch
            {
                StringToolChoiceOptions.None => "none",
                StringToolChoiceOptions.Auto => "auto",
                StringToolChoiceOptions.Required => "required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StringToolChoiceOptions? ToEnum(string value)
        {
            return value switch
            {
                "none" => StringToolChoiceOptions.None,
                "auto" => StringToolChoiceOptions.Auto,
                "required" => StringToolChoiceOptions.Required,
                _ => null,
            };
        }
    }
}