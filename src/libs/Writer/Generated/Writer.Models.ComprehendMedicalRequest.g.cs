
#nullable enable

namespace Writer
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ComprehendMedicalRequest
    {
        /// <summary>
        /// The text to analyze.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Writer.JsonConverters.ComprehendMedicalTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Writer.ComprehendMedicalType ResponseType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ComprehendMedicalRequest" /> class.
        /// </summary>
        /// <param name="content">
        /// The text to analyze.
        /// </param>
        /// <param name="responseType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ComprehendMedicalRequest(
            string content,
            global::Writer.ComprehendMedicalType responseType)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.ResponseType = responseType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComprehendMedicalRequest" /> class.
        /// </summary>
        public ComprehendMedicalRequest()
        {
        }
    }
}