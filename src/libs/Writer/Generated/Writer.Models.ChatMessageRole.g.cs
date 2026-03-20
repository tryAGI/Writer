
#nullable enable

namespace Writer
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        User,
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatMessageRole value)
        {
            return value switch
            {
                ChatMessageRole.User => "user",
                ChatMessageRole.Assistant => "assistant",
                ChatMessageRole.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "user" => ChatMessageRole.User,
                "assistant" => ChatMessageRole.Assistant,
                "system" => ChatMessageRole.System,
                _ => null,
            };
        }
    }
}