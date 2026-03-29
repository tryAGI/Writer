
#nullable enable

namespace Writer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GraphTool
    {
        /// <summary>
        /// The type of tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Writer.JsonConverters.GraphToolTypeJsonConverter))]
        public global::Writer.GraphToolType Type { get; set; }

        /// <summary>
        /// A tool that uses Knowledge Graphs as context for responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Writer.GraphFunction Function { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphTool" /> class.
        /// </summary>
        /// <param name="function">
        /// A tool that uses Knowledge Graphs as context for responses.
        /// </param>
        /// <param name="type">
        /// The type of tool.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GraphTool(
            global::Writer.GraphFunction function,
            global::Writer.GraphToolType type)
        {
            this.Type = type;
            this.Function = function ?? throw new global::System.ArgumentNullException(nameof(function));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphTool" /> class.
        /// </summary>
        public GraphTool()
        {
        }
    }
}