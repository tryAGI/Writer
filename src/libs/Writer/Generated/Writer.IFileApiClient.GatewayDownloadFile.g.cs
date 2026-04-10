#nullable enable

namespace Writer
{
    public partial interface IFileApiClient
    {
        /// <summary>
        /// Download file<br/>
        /// Download the binary content of a file. The response will contain the file data in the appropriate MIME type.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Writer.ApiException"></exception>
        /// <remarks>
        /// curl --location --request GET https://api.writer.com/v1/files/{file_id}/download \<br/>
        ///  --header "Authorization: Bearer &lt;token&gt;"
        /// </remarks>
        global::System.Threading.Tasks.Task<byte[]> GatewayDownloadFileAsync(
            string fileId,
            global::Writer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Download file<br/>
        /// Download the binary content of a file. The response will contain the file data in the appropriate MIME type.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Writer.ApiException"></exception>
        /// <remarks>
        /// curl --location --request GET https://api.writer.com/v1/files/{file_id}/download \<br/>
        ///  --header "Authorization: Bearer &lt;token&gt;"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Writer.AutoSDKHttpResponse<byte[]>> GatewayDownloadFileAsResponseAsync(
            string fileId,
            global::Writer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}