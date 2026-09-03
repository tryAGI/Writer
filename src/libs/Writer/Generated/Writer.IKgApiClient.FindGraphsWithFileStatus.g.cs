#nullable enable

namespace Writer
{
    public partial interface IKgApiClient
    {
        /// <summary>
        /// List graphs<br/>
        /// Retrieve a list of Knowledge Graphs.<br/>
        /// By default, the response contains only org-wide Knowledge Graphs. To include Knowledge Graphs that are deployed to specific teams, pass one or more team IDs in the `team_ids` query parameter. Requests authenticated with a team-scoped API key always return only that key's team; passing a different value in `team_ids` is rejected.
        /// </summary>
        /// <param name="order">
        /// Default Value: desc
        /// </param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="teamIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Writer.ApiException"></exception>
        /// <remarks>
        /// curl --location --request GET https://api.writer.com/v1/graphs \<br/>
        ///  --header "Authorization: Bearer &lt;token&gt;"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Writer.GraphsResponse> FindGraphsWithFileStatusAsync(
            global::Writer.FindGraphsWithFileStatusOrder? order = default,
            global::System.Guid? before = default,
            global::System.Guid? after = default,
            int? limit = default,
            global::System.Collections.Generic.IList<long>? teamIds = default,
            global::Writer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List graphs<br/>
        /// Retrieve a list of Knowledge Graphs.<br/>
        /// By default, the response contains only org-wide Knowledge Graphs. To include Knowledge Graphs that are deployed to specific teams, pass one or more team IDs in the `team_ids` query parameter. Requests authenticated with a team-scoped API key always return only that key's team; passing a different value in `team_ids` is rejected.
        /// </summary>
        /// <param name="order">
        /// Default Value: desc
        /// </param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="teamIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Writer.ApiException"></exception>
        /// <remarks>
        /// curl --location --request GET https://api.writer.com/v1/graphs \<br/>
        ///  --header "Authorization: Bearer &lt;token&gt;"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Writer.AutoSDKHttpResponse<global::Writer.GraphsResponse>> FindGraphsWithFileStatusAsResponseAsync(
            global::Writer.FindGraphsWithFileStatusOrder? order = default,
            global::System.Guid? before = default,
            global::System.Guid? after = default,
            int? limit = default,
            global::System.Collections.Generic.IList<long>? teamIds = default,
            global::Writer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}