
#nullable enable

namespace Writer
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCompletionFinishReason
    {
        /// <summary>
        /// 
        /// </summary>
        Stop,
        /// <summary>
        /// 
        /// </summary>
        Length,
        /// <summary>
        /// 
        /// </summary>
        ContentFilter,
        /// <summary>
        /// 
        /// </summary>
        ToolCalls,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionFinishReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionFinishReason value)
        {
            return value switch
            {
                ChatCompletionFinishReason.Stop => "stop",
                ChatCompletionFinishReason.Length => "length",
                ChatCompletionFinishReason.ContentFilter => "content_filter",
                ChatCompletionFinishReason.ToolCalls => "tool_calls",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionFinishReason? ToEnum(string value)
        {
            return value switch
            {
                "stop" => ChatCompletionFinishReason.Stop,
                "length" => ChatCompletionFinishReason.Length,
                "content_filter" => ChatCompletionFinishReason.ContentFilter,
                "tool_calls" => ChatCompletionFinishReason.ToolCalls,
                _ => null,
            };
        }
    }
}