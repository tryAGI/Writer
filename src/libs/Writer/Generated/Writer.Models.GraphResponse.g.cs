
#nullable enable

namespace Writer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GraphResponse
    {
        /// <summary>
        /// A unique identifier of the Knowledge Graph.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// The timestamp when the Knowledge Graph was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The name of the Knowledge Graph (max 255 characters).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A description of the Knowledge Graph (max 255 characters).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// An array of web connector URLs associated with this Knowledge Graph.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("urls")]
        public global::System.Collections.Generic.IList<global::Writer.WebConnectorUrl>? Urls { get; set; }

        /// <summary>
        /// The team IDs the Knowledge Graph is deployed to. An empty array indicates an org-wide Knowledge Graph accessible to every team in the organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_ids")]
        public global::System.Collections.Generic.IList<long>? TeamIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// A unique identifier of the Knowledge Graph.
        /// </param>
        /// <param name="createdAt">
        /// The timestamp when the Knowledge Graph was created.
        /// </param>
        /// <param name="name">
        /// The name of the Knowledge Graph (max 255 characters).
        /// </param>
        /// <param name="description">
        /// A description of the Knowledge Graph (max 255 characters).
        /// </param>
        /// <param name="urls">
        /// An array of web connector URLs associated with this Knowledge Graph.
        /// </param>
        /// <param name="teamIds">
        /// The team IDs the Knowledge Graph is deployed to. An empty array indicates an org-wide Knowledge Graph accessible to every team in the organization.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GraphResponse(
            global::System.Guid id,
            global::System.DateTime createdAt,
            string name,
            string? description,
            global::System.Collections.Generic.IList<global::Writer.WebConnectorUrl>? urls,
            global::System.Collections.Generic.IList<long>? teamIds)
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Urls = urls;
            this.TeamIds = teamIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphResponse" /> class.
        /// </summary>
        public GraphResponse()
        {
        }

    }
}