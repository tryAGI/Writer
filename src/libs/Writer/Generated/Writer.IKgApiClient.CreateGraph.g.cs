#nullable enable

namespace Writer
{
    public partial interface IKgApiClient
    {
        /// <summary>
        /// Create graph<br/>
        /// Create a new Knowledge Graph.<br/>
        /// By default, the new Knowledge Graph is org-wide (accessible to every team in the organization). To deploy the Knowledge Graph to specific teams instead, provide a `team_ids` array in the request body. When the request is authenticated with a team-scoped API key, the new Knowledge Graph is automatically assigned to that key's team and `team_ids` in the body is not accepted.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Writer.ApiException"></exception>
        /// <remarks>
        /// curl --location --request POST https://api.writer.com/v1/graphs \<br/>
        ///  --header "Authorization: Bearer &lt;token&gt;" \<br/>
        ///  --header "Content-Type: application/json" \<br/>
        /// --data-raw '{"name":"string"}'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Writer.GraphResponse> CreateGraphAsync(

            global::Writer.GraphRequest request,
            global::Writer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create graph<br/>
        /// Create a new Knowledge Graph.<br/>
        /// By default, the new Knowledge Graph is org-wide (accessible to every team in the organization). To deploy the Knowledge Graph to specific teams instead, provide a `team_ids` array in the request body. When the request is authenticated with a team-scoped API key, the new Knowledge Graph is automatically assigned to that key's team and `team_ids` in the body is not accepted.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Writer.ApiException"></exception>
        /// <remarks>
        /// curl --location --request POST https://api.writer.com/v1/graphs \<br/>
        ///  --header "Authorization: Bearer &lt;token&gt;" \<br/>
        ///  --header "Content-Type: application/json" \<br/>
        /// --data-raw '{"name":"string"}'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Writer.AutoSDKHttpResponse<global::Writer.GraphResponse>> CreateGraphAsResponseAsync(

            global::Writer.GraphRequest request,
            global::Writer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create graph<br/>
        /// Create a new Knowledge Graph.<br/>
        /// By default, the new Knowledge Graph is org-wide (accessible to every team in the organization). To deploy the Knowledge Graph to specific teams instead, provide a `team_ids` array in the request body. When the request is authenticated with a team-scoped API key, the new Knowledge Graph is automatically assigned to that key's team and `team_ids` in the body is not accepted.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Writer.GraphResponse> CreateGraphAsync(
            string? name = default,
            string? description = default,
            global::System.Collections.Generic.IList<long>? teamIds = default,
            global::Writer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}