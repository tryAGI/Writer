
#nullable enable

namespace Writer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateGraphRequest
    {
        /// <summary>
        /// The name of the Knowledge Graph (max 255 characters). Omitting this field leaves the name unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A description of the Knowledge Graph (max 255 characters). Omitting this field leaves the description unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// An array of web connector URLs to update for this Knowledge Graph. You can only connect URLs to Knowledge Graphs with the type `web`. To clear the list of URLs, set this field to an empty array.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("urls")]
        public global::System.Collections.Generic.IList<global::Writer.UpdateGraphWebUrl>? Urls { get; set; }

        /// <summary>
        /// Optional list of team IDs the Knowledge Graph is deployed to. Omitting this field leaves the current team assignment unchanged. Passing an array replaces the whole team assignment: an empty array makes the graph org-wide, one or more team IDs scope it to exactly those teams. Not accepted from team-scoped API keys.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_ids")]
        public global::System.Collections.Generic.IList<long>? TeamIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateGraphRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the Knowledge Graph (max 255 characters). Omitting this field leaves the name unchanged.
        /// </param>
        /// <param name="description">
        /// A description of the Knowledge Graph (max 255 characters). Omitting this field leaves the description unchanged.
        /// </param>
        /// <param name="urls">
        /// An array of web connector URLs to update for this Knowledge Graph. You can only connect URLs to Knowledge Graphs with the type `web`. To clear the list of URLs, set this field to an empty array.
        /// </param>
        /// <param name="teamIds">
        /// Optional list of team IDs the Knowledge Graph is deployed to. Omitting this field leaves the current team assignment unchanged. Passing an array replaces the whole team assignment: an empty array makes the graph org-wide, one or more team IDs scope it to exactly those teams. Not accepted from team-scoped API keys.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateGraphRequest(
            string? name,
            string? description,
            global::System.Collections.Generic.IList<global::Writer.UpdateGraphWebUrl>? urls,
            global::System.Collections.Generic.IList<long>? teamIds)
        {
            this.Name = name;
            this.Description = description;
            this.Urls = urls;
            this.TeamIds = teamIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateGraphRequest" /> class.
        /// </summary>
        public UpdateGraphRequest()
        {
        }

    }
}