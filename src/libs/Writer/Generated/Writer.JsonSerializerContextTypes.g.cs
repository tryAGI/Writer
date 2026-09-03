
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Writer
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::Writer.ModelInfo? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.ModelsResponse? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Writer.ModelInfo>? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.Logprobs? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Writer.LogprobsToken>? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.LogprobsToken? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Writer.TopLogProb>? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.TopLogProb? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.CompletionsChoice? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.CompletionsResponse? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Writer.CompletionsChoice>? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.StreamingData? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.Map? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.CompletionsRequest? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.OneOf<global::System.Collections.Generic.IList<string>, string>? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.FailMessage? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.FailResponse? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Writer.FailMessage>? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.ChatCompletionChoice? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.ChatCompletionFinishReason? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.ChatCompletionResponseMessage? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.ChatCompletionStreamingChoice? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.ChatCompletionStreamingDelta? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.ChatRequest? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Writer.ChatMessage>? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.ChatMessage? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Writer.Tool>? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.Tool? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.ToolChoice? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.StreamOptions? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.ResponseFormat? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.ResponseFormatType? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.ChatResponse? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Guid? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.ChatResponseObject? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Writer.ChatCompletionChoice>? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTimeOffset? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.ChatCompletionUsage? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.ChatCompletionChunk? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.ChatCompletionChunkObject? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Writer.ChatCompletionStreamingChoice>? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.ChatCompletionResponseMessageRole? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Writer.ToolCall>? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.ToolCall? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.GraphData? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.LlmData? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.TranslationData? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.WebSearchData? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.ChatMessageRole? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Writer.ToolCallStreaming>? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.ToolCallStreaming? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.PromptTokenDetails? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.CompletionTokenDetails? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.OneOf<string, global::System.Collections.Generic.IList<global::Writer.CompositeContent>>? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Writer.CompositeContent>? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.CompositeContent? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.ChatMessageRequestRole? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.DeleteFileResponse? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.RetryFilesResponse? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.FileResponse? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Guid>? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.GraphType? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.FilesResponse? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Writer.FileResponse>? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.ApplicationGraphIdsRequest? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.ApplicationGraphsResponse? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Writer.Source?>? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.Source? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.GraphStageStatus? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Writer.SubQuery?>? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.SubQuery? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.References? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Writer.WebSearchDataSource>? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.WebSearchDataSource? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.GraphResponse? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Writer.WebConnectorUrl>? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.WebConnectorUrl? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<long>? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.DeleteGraphResponse? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.RetryFilesRequest? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.GraphFileRequest? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.GraphFileStatus? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.GraphRequest? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.UpdateGraphRequest? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Writer.UpdateGraphWebUrl>? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.UpdateGraphWebUrl? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.WebConnectorUrlType? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.GraphsResponse? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Writer.Graph>? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.Graph? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.WebConnectorUrlState? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.WebConnectorUrlStatus? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.WebConnectorUrlErrorType? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.GenerateApplicationInput? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.GenerateApplicationRequest? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Writer.GenerateApplicationInput>? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.GetAsyncApplicationJobsResponse? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Writer.GetAsyncApplicationJobResponse>? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.GetAsyncApplicationJobResponse? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.GetAsyncApplicationJobsResponsePagination? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.ApiJobStatus? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.GenerateApplicationResponse? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.GenerateApplicationAsyncRequest? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.GenerateApplicationAsyncResponse? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.RetryAsyncApplicationJobResponse? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.ApplicationType? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.GetApplicationsResponse? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Writer.ApplicationWithInputs>? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.ApplicationWithInputs? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.ApplicationStatus? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Writer.ApplicationInput>? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.ApplicationInput? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.ApplicationInputType? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.ApplicationInputOptions? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.ApplicationInputDropdownOptions? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.ApplicationInputFileOptions? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.ApplicationInputMediaOptions? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.ApplicationInputTextOptions? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Writer.FileUploadType>? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.FileUploadType? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.GenerateApplicationResponseChunk? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.GenerateApplicationDelta? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Writer.GenerateApplicationChunkStage>? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.GenerateApplicationChunkStage? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.QuestionRequest? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.GraphQueryConfig? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.QuestionResponseChunk? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.QuestionResponse? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.FunctionTool? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.GraphTool? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.LlmTool? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.TranslationTool? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.VisionTool? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.WebSearchTool? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.ToolDiscriminator? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.ToolDiscriminatorType? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.FunctionToolType? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.ToolFunction? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.GraphToolType? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.GraphFunction? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.LlmToolType? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.LlmFunction? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.VisionToolType? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.VisionFunction? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Writer.VisionToolRequestFileVariable>? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.VisionToolRequestFileVariable? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.VisionFunctionModel? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.ToolCallType? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.Function? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.ToolCallStreamingType? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.StringToolChoice? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.JsonObjectToolChoice? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.StringToolChoiceOptions? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.ParsePdfRequest? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.PdfConversionFormat? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.ParsePdfResponse? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.VisionRequest? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.VisionRequestModel? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Writer.VisionRequestFileVariable>? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.VisionRequestFileVariable? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.VisionResponse? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.TranslationToolType? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.TranslationFunction? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.TranslationFunctionModel? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.WebSearchRequest? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.WebSearchRequestTopic? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.WebSearchRequestSearchDepth? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.WebSearchRequestTimeRange? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.OneOf<global::Writer.WebSearchRequestIncludeRawContent?, bool?>? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.WebSearchRequestIncludeRawContent? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.WebSearchRequestCountry? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.WebSearchResponse? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Writer.WebSearchResponseSource>? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.WebSearchResponseSource? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.WebSearchToolType? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.WebSearchFunction? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.TextFragment? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.ImageFragment? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.TextFragmentType? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.ImageFragmentType? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.ImageFragmentImageUrl? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Writer.File>? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.File? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Writer.Web>? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.Web? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.FindGraphsWithFileStatusOrder? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.GatewayGetFilesOrder? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.GatewayGetFilesStatus? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.GetApplicationsOrder? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Writer.ChatCompletionChunk>? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Writer.StreamingData>? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Writer.GenerateApplicationResponseChunk>? Type201 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Writer.ModelInfo>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Writer.LogprobsToken>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Writer.TopLogProb>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Writer.CompletionsChoice>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.OneOf<global::System.Collections.Generic.List<string>, string>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Writer.FailMessage>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Writer.ChatMessage>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Writer.Tool>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Writer.ChatCompletionChoice>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Writer.ChatCompletionStreamingChoice>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Writer.ToolCall>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Writer.ToolCallStreaming>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Writer.OneOf<string, global::System.Collections.Generic.List<global::Writer.CompositeContent>>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Writer.CompositeContent>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Guid>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Writer.FileResponse>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Writer.Source?>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Writer.SubQuery?>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Writer.WebSearchDataSource>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Writer.WebConnectorUrl>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<long>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Writer.UpdateGraphWebUrl>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Writer.Graph>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Writer.GenerateApplicationInput>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Writer.GetAsyncApplicationJobResponse>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Writer.ApplicationWithInputs>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Writer.ApplicationInput>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Writer.FileUploadType>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Writer.GenerateApplicationChunkStage>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Writer.VisionToolRequestFileVariable>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Writer.VisionRequestFileVariable>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Writer.WebSearchResponseSource>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Writer.File>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Writer.Web>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Writer.ChatCompletionChunk>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Writer.StreamingData>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Writer.GenerateApplicationResponseChunk>? ListType38 { get; set; }
    }
}