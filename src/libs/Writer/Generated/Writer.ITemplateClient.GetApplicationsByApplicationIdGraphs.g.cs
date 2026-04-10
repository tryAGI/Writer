#nullable enable

namespace Writer
{
    public partial interface ITemplateClient
    {
        /// <summary>
        /// Retrieve graphs<br/>
        /// Retrieve Knowledge Graphs associated with a no-code agent that has chat capabilities.
        /// </summary>
        /// <param name="applicationId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Writer.ApiException"></exception>
        /// <remarks>
        /// curl --location --request GET https://api.writer.com/v1/applications/{application_id}/graphs \<br/>
        ///  --header "Authorization: Bearer &lt;token&gt;"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Writer.ApplicationGraphsResponse> GetApplicationsByApplicationIdGraphsAsync(
            string applicationId,
            global::Writer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}