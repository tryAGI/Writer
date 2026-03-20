
#nullable enable

namespace Writer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GraphData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sources")]
        public global::System.Collections.Generic.IList<global::Writer.Source>? Sources { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Writer.JsonConverters.GraphStageStatusJsonConverter))]
        public global::Writer.GraphStageStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subqueries")]
        public global::System.Collections.Generic.IList<global::Writer.SubQuery>? Subqueries { get; set; }

        /// <summary>
        /// Detailed source information organized by reference type, providing comprehensive metadata about the sources used to generate the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("references")]
        public global::Writer.References? References { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphData" /> class.
        /// </summary>
        /// <param name="sources"></param>
        /// <param name="status"></param>
        /// <param name="subqueries"></param>
        /// <param name="references">
        /// Detailed source information organized by reference type, providing comprehensive metadata about the sources used to generate the response.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GraphData(
            global::System.Collections.Generic.IList<global::Writer.Source>? sources,
            global::Writer.GraphStageStatus? status,
            global::System.Collections.Generic.IList<global::Writer.SubQuery>? subqueries,
            global::Writer.References? references)
        {
            this.Sources = sources;
            this.Status = status;
            this.Subqueries = subqueries;
            this.References = references;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphData" /> class.
        /// </summary>
        public GraphData()
        {
        }
    }
}