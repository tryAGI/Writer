
#nullable enable

namespace Writer
{
    /// <summary>
    /// The chat completion message from the model. Note: this field is deprecated for streaming. Use `delta` instead.
    /// </summary>
    public sealed partial class ChatCompletionResponseMessage
    {
        /// <summary>
        /// The text content produced by the model. This field contains the actual output generated, reflecting the model's response to the input query or command.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// Specifies the role associated with the content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Writer.JsonConverters.ChatCompletionResponseMessageRoleJsonConverter))]
        public global::Writer.ChatCompletionResponseMessageRole Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_calls")]
        public global::System.Collections.Generic.IList<global::Writer.ToolCall>? ToolCalls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("graph_data")]
        public global::Writer.GraphData? GraphData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_data")]
        public global::Writer.LlmData? LlmData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("translation_data")]
        public global::Writer.TranslationData? TranslationData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("web_search_data")]
        public global::Writer.WebSearchData? WebSearchData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refusal")]
        public string? Refusal { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionResponseMessage" /> class.
        /// </summary>
        /// <param name="content">
        /// The text content produced by the model. This field contains the actual output generated, reflecting the model's response to the input query or command.
        /// </param>
        /// <param name="role">
        /// Specifies the role associated with the content.
        /// </param>
        /// <param name="toolCalls"></param>
        /// <param name="graphData"></param>
        /// <param name="llmData"></param>
        /// <param name="translationData"></param>
        /// <param name="webSearchData"></param>
        /// <param name="refusal"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionResponseMessage(
            string content,
            global::Writer.ChatCompletionResponseMessageRole role,
            global::System.Collections.Generic.IList<global::Writer.ToolCall>? toolCalls,
            global::Writer.GraphData? graphData,
            global::Writer.LlmData? llmData,
            global::Writer.TranslationData? translationData,
            global::Writer.WebSearchData? webSearchData,
            string? refusal)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Role = role;
            this.ToolCalls = toolCalls;
            this.GraphData = graphData;
            this.LlmData = llmData;
            this.TranslationData = translationData;
            this.WebSearchData = webSearchData;
            this.Refusal = refusal;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionResponseMessage" /> class.
        /// </summary>
        public ChatCompletionResponseMessage()
        {
        }
    }
}