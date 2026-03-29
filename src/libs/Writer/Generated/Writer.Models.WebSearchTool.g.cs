
#nullable enable

namespace Writer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebSearchTool
    {
        /// <summary>
        /// The type of tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Writer.JsonConverters.WebSearchToolTypeJsonConverter))]
        public global::Writer.WebSearchToolType Type { get; set; }

        /// <summary>
        /// A tool that uses web search to find information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Writer.WebSearchFunction Function { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchTool" /> class.
        /// </summary>
        /// <param name="function">
        /// A tool that uses web search to find information.
        /// </param>
        /// <param name="type">
        /// The type of tool.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebSearchTool(
            global::Writer.WebSearchFunction function,
            global::Writer.WebSearchToolType type)
        {
            this.Type = type;
            this.Function = function ?? throw new global::System.ArgumentNullException(nameof(function));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchTool" /> class.
        /// </summary>
        public WebSearchTool()
        {
        }
    }
}