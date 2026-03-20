#nullable enable

namespace Writer
{
    public partial interface IGenerationApiClient
    {

        /// <summary>
        /// List models<br/>
        /// Retrieve a list of available models that can be used for text generation, chat completions, and other AI tasks.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Writer.ApiException"></exception>

        /// <remarks>
        /// curl --location --request GET https://api.writer.com/v1/models \<br/>
        ///  --header "Authorization: Bearer &lt;token&gt;"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Writer.ModelsResponse> ModelsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}