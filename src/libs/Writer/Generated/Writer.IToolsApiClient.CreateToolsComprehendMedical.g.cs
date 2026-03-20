#nullable enable

namespace Writer
{
    public partial interface IToolsApiClient
    {
        /// <summary>
        /// Medical comprehend<br/>
        /// Analyze unstructured medical text to extract entities labeled with standardized medical codes and confidence scores.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Writer.ApiException"></exception>
        /// <remarks>
        /// curl --location --request POST https://api.writer.com/v1/tools/comprehend/medical \<br/>
        ///  --header "Authorization: Bearer &lt;token&gt;" \<br/>
        ///  --header "Content-Type: application/json" \<br/>
        /// --data-raw '{"content":"the symptoms are soreness, a temperature and cough","response_type":"Entities"}'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Writer.MedicalComprehendResponse> CreateToolsComprehendMedicalAsync(

            global::Writer.ComprehendMedicalRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Medical comprehend<br/>
        /// Analyze unstructured medical text to extract entities labeled with standardized medical codes and confidence scores.
        /// </summary>
        /// <param name="content">
        /// The text to analyze.
        /// </param>
        /// <param name="responseType"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Writer.MedicalComprehendResponse> CreateToolsComprehendMedicalAsync(
            string content,
            global::Writer.ComprehendMedicalType responseType,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}