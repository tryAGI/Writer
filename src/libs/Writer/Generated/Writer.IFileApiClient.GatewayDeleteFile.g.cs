#nullable enable

namespace Writer
{
    public partial interface IFileApiClient
    {
        /// <summary>
        /// Delete file<br/>
        /// Permanently delete a file from the system. This action cannot be undone.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Writer.ApiException"></exception>
        /// <remarks>
        /// curl --location --request DELETE https://api.writer.com/v1/files/{file_id} \<br/>
        ///  --header "Authorization: Bearer &lt;token&gt;"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Writer.DeleteFileResponse> GatewayDeleteFileAsync(
            string fileId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}