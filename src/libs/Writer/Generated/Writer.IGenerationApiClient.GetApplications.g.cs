#nullable enable

namespace Writer
{
    public partial interface IGenerationApiClient
    {
        /// <summary>
        /// List applications<br/>
        /// Retrieves a paginated list of no-code agents (formerly called no-code applications) with optional filtering and sorting capabilities.
        /// </summary>
        /// <param name="order">
        /// Default Value: desc
        /// </param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="type">
        /// The type of no-code application.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Writer.ApiException"></exception>
        /// <remarks>
        /// curl --location --request GET https://api.writer.com/v1/applications \<br/>
        ///  --header "Authorization: Bearer &lt;token&gt;"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Writer.GetApplicationsResponse> GetApplicationsAsync(
            global::Writer.GetApplicationsOrder? order = default,
            global::System.Guid? before = default,
            global::System.Guid? after = default,
            int? limit = default,
            global::Writer.ApplicationType? type = default,
            global::Writer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}