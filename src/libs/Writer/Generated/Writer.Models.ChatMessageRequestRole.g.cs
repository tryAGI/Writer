
#nullable enable

namespace Writer
{
    /// <summary>
    /// The role of the chat message. You can provide a system prompt by setting the role to `system`, or specify that a message is the result of a [tool call](https://dev.writer.com/home/tool-calling) by setting the role to `tool`.
    /// </summary>
    public enum ChatMessageRequestRole
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
        /// //dev.writer.com/home/tool-calling) by setting the role to `tool`.
        /// </summary>
        System,
        /// <summary>
        /// //dev.writer.com/home/tool-calling) by setting the role to `tool`.
        /// </summary>
        Tool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatMessageRequestRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatMessageRequestRole value)
        {
            return value switch
            {
                ChatMessageRequestRole.User => "user",
                ChatMessageRequestRole.Assistant => "assistant",
                ChatMessageRequestRole.System => "system",
                ChatMessageRequestRole.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatMessageRequestRole? ToEnum(string value)
        {
            return value switch
            {
                "user" => ChatMessageRequestRole.User,
                "assistant" => ChatMessageRequestRole.Assistant,
                "system" => ChatMessageRequestRole.System,
                "tool" => ChatMessageRequestRole.Tool,
                _ => null,
            };
        }
    }
}