#nullable enable

namespace Writer
{
    public partial interface IKgApiClient
    {
        /// <summary>
        /// Delete graph<br/>
        /// Delete a Knowledge Graph.
        /// </summary>
        /// <param name="graphId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Writer.ApiException"></exception>
        /// <remarks>
        /// curl --location --request DELETE https://api.writer.com/v1/graphs/{graph_id} \<br/>
        ///  --header "Authorization: Bearer &lt;token&gt;"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Writer.DeleteGraphResponse> DeleteGraphAsync(
            global::System.Guid graphId,
            global::Writer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}