
#nullable enable

namespace Writer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GraphRequest
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
        /// Optional list of team IDs to deploy the Knowledge Graph to. Omit the field or pass an empty array to create an org-wide Knowledge Graph (accessible to every team in the organization), which is the default. Provide one or more team IDs to scope the Knowledge Graph to those teams. Only applies when using an org-scoped API key; requests made with a team-scoped API key ignore this field and always assign the graph to that key's team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_ids")]
        public global::System.Collections.Generic.IList<long>? TeamIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the Knowledge Graph (max 255 characters). Omitting this field leaves the name unchanged.
        /// </param>
        /// <param name="description">
        /// A description of the Knowledge Graph (max 255 characters). Omitting this field leaves the description unchanged.
        /// </param>
        /// <param name="teamIds">
        /// Optional list of team IDs to deploy the Knowledge Graph to. Omit the field or pass an empty array to create an org-wide Knowledge Graph (accessible to every team in the organization), which is the default. Provide one or more team IDs to scope the Knowledge Graph to those teams. Only applies when using an org-scoped API key; requests made with a team-scoped API key ignore this field and always assign the graph to that key's team.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GraphRequest(
            string? name,
            string? description,
            global::System.Collections.Generic.IList<long>? teamIds)
        {
            this.Name = name;
            this.Description = description;
            this.TeamIds = teamIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphRequest" /> class.
        /// </summary>
        public GraphRequest()
        {
        }

    }
}