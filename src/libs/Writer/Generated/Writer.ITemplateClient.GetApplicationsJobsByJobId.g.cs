#nullable enable

namespace Writer
{
    public partial interface ITemplateClient
    {

        /// <summary>
        /// Retrieve a single job<br/>
        /// Retrieves a single job created via the Async API.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Writer.ApiException"></exception>

        /// <remarks>
        /// curl --location --request GET https://api.writer.com/v1/applications/jobs/{job_id} \<br/>
        ///  --header "Authorization: Bearer &lt;token&gt;"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Writer.GetAsyncApplicationJobResponse> GetApplicationsJobsByJobIdAsync(
            global::System.Guid jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}