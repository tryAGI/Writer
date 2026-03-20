
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Writer
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Writer.JsonConverters.ChatCompletionFinishReasonJsonConverter),

            typeof(global::Writer.JsonConverters.ChatCompletionFinishReasonNullableJsonConverter),

            typeof(global::Writer.JsonConverters.ResponseFormatTypeJsonConverter),

            typeof(global::Writer.JsonConverters.ResponseFormatTypeNullableJsonConverter),

            typeof(global::Writer.JsonConverters.ChatResponseObjectJsonConverter),

            typeof(global::Writer.JsonConverters.ChatResponseObjectNullableJsonConverter),

            typeof(global::Writer.JsonConverters.ChatCompletionChunkObjectJsonConverter),

            typeof(global::Writer.JsonConverters.ChatCompletionChunkObjectNullableJsonConverter),

            typeof(global::Writer.JsonConverters.ChatCompletionResponseMessageRoleJsonConverter),

            typeof(global::Writer.JsonConverters.ChatCompletionResponseMessageRoleNullableJsonConverter),

            typeof(global::Writer.JsonConverters.ChatMessageRoleJsonConverter),

            typeof(global::Writer.JsonConverters.ChatMessageRoleNullableJsonConverter),

            typeof(global::Writer.JsonConverters.ChatMessageRequestRoleJsonConverter),

            typeof(global::Writer.JsonConverters.ChatMessageRequestRoleNullableJsonConverter),

            typeof(global::Writer.JsonConverters.GraphTypeJsonConverter),

            typeof(global::Writer.JsonConverters.GraphTypeNullableJsonConverter),

            typeof(global::Writer.JsonConverters.GraphStageStatusJsonConverter),

            typeof(global::Writer.JsonConverters.GraphStageStatusNullableJsonConverter),

            typeof(global::Writer.JsonConverters.WebConnectorUrlTypeJsonConverter),

            typeof(global::Writer.JsonConverters.WebConnectorUrlTypeNullableJsonConverter),

            typeof(global::Writer.JsonConverters.WebConnectorUrlErrorTypeJsonConverter),

            typeof(global::Writer.JsonConverters.WebConnectorUrlErrorTypeNullableJsonConverter),

            typeof(global::Writer.JsonConverters.WebConnectorUrlStatusJsonConverter),

            typeof(global::Writer.JsonConverters.WebConnectorUrlStatusNullableJsonConverter),

            typeof(global::Writer.JsonConverters.ApiJobStatusJsonConverter),

            typeof(global::Writer.JsonConverters.ApiJobStatusNullableJsonConverter),

            typeof(global::Writer.JsonConverters.ApplicationTypeJsonConverter),

            typeof(global::Writer.JsonConverters.ApplicationTypeNullableJsonConverter),

            typeof(global::Writer.JsonConverters.ApplicationStatusJsonConverter),

            typeof(global::Writer.JsonConverters.ApplicationStatusNullableJsonConverter),

            typeof(global::Writer.JsonConverters.ApplicationInputTypeJsonConverter),

            typeof(global::Writer.JsonConverters.ApplicationInputTypeNullableJsonConverter),

            typeof(global::Writer.JsonConverters.FileUploadTypeJsonConverter),

            typeof(global::Writer.JsonConverters.FileUploadTypeNullableJsonConverter),

            typeof(global::Writer.JsonConverters.ToolDiscriminatorTypeJsonConverter),

            typeof(global::Writer.JsonConverters.ToolDiscriminatorTypeNullableJsonConverter),

            typeof(global::Writer.JsonConverters.FunctionToolTypeJsonConverter),

            typeof(global::Writer.JsonConverters.FunctionToolTypeNullableJsonConverter),

            typeof(global::Writer.JsonConverters.GraphToolTypeJsonConverter),

            typeof(global::Writer.JsonConverters.GraphToolTypeNullableJsonConverter),

            typeof(global::Writer.JsonConverters.LlmToolTypeJsonConverter),

            typeof(global::Writer.JsonConverters.LlmToolTypeNullableJsonConverter),

            typeof(global::Writer.JsonConverters.VisionToolTypeJsonConverter),

            typeof(global::Writer.JsonConverters.VisionToolTypeNullableJsonConverter),

            typeof(global::Writer.JsonConverters.VisionFunctionModelJsonConverter),

            typeof(global::Writer.JsonConverters.VisionFunctionModelNullableJsonConverter),

            typeof(global::Writer.JsonConverters.ToolCallTypeJsonConverter),

            typeof(global::Writer.JsonConverters.ToolCallTypeNullableJsonConverter),

            typeof(global::Writer.JsonConverters.ToolCallStreamingTypeJsonConverter),

            typeof(global::Writer.JsonConverters.ToolCallStreamingTypeNullableJsonConverter),

            typeof(global::Writer.JsonConverters.StringToolChoiceOptionsJsonConverter),

            typeof(global::Writer.JsonConverters.StringToolChoiceOptionsNullableJsonConverter),

            typeof(global::Writer.JsonConverters.AiDetectionResponseLabelJsonConverter),

            typeof(global::Writer.JsonConverters.AiDetectionResponseLabelNullableJsonConverter),

            typeof(global::Writer.JsonConverters.ComprehendMedicalTypeJsonConverter),

            typeof(global::Writer.JsonConverters.ComprehendMedicalTypeNullableJsonConverter),

            typeof(global::Writer.JsonConverters.SplittingStrategyJsonConverter),

            typeof(global::Writer.JsonConverters.SplittingStrategyNullableJsonConverter),

            typeof(global::Writer.JsonConverters.PdfConversionFormatJsonConverter),

            typeof(global::Writer.JsonConverters.PdfConversionFormatNullableJsonConverter),

            typeof(global::Writer.JsonConverters.VisionRequestModelJsonConverter),

            typeof(global::Writer.JsonConverters.VisionRequestModelNullableJsonConverter),

            typeof(global::Writer.JsonConverters.TranslationRequestModelJsonConverter),

            typeof(global::Writer.JsonConverters.TranslationRequestModelNullableJsonConverter),

            typeof(global::Writer.JsonConverters.TranslationToolTypeJsonConverter),

            typeof(global::Writer.JsonConverters.TranslationToolTypeNullableJsonConverter),

            typeof(global::Writer.JsonConverters.TranslationFunctionModelJsonConverter),

            typeof(global::Writer.JsonConverters.TranslationFunctionModelNullableJsonConverter),

            typeof(global::Writer.JsonConverters.WebSearchRequestTopicJsonConverter),

            typeof(global::Writer.JsonConverters.WebSearchRequestTopicNullableJsonConverter),

            typeof(global::Writer.JsonConverters.WebSearchRequestSearchDepthJsonConverter),

            typeof(global::Writer.JsonConverters.WebSearchRequestSearchDepthNullableJsonConverter),

            typeof(global::Writer.JsonConverters.WebSearchRequestTimeRangeJsonConverter),

            typeof(global::Writer.JsonConverters.WebSearchRequestTimeRangeNullableJsonConverter),

            typeof(global::Writer.JsonConverters.WebSearchRequestIncludeRawContentJsonConverter),

            typeof(global::Writer.JsonConverters.WebSearchRequestIncludeRawContentNullableJsonConverter),

            typeof(global::Writer.JsonConverters.WebSearchRequestCountryJsonConverter),

            typeof(global::Writer.JsonConverters.WebSearchRequestCountryNullableJsonConverter),

            typeof(global::Writer.JsonConverters.WebSearchToolTypeJsonConverter),

            typeof(global::Writer.JsonConverters.WebSearchToolTypeNullableJsonConverter),

            typeof(global::Writer.JsonConverters.TextFragmentTypeJsonConverter),

            typeof(global::Writer.JsonConverters.TextFragmentTypeNullableJsonConverter),

            typeof(global::Writer.JsonConverters.ImageFragmentTypeJsonConverter),

            typeof(global::Writer.JsonConverters.ImageFragmentTypeNullableJsonConverter),

            typeof(global::Writer.JsonConverters.FindGraphsWithFileStatusOrderJsonConverter),

            typeof(global::Writer.JsonConverters.FindGraphsWithFileStatusOrderNullableJsonConverter),

            typeof(global::Writer.JsonConverters.GatewayGetFilesOrderJsonConverter),

            typeof(global::Writer.JsonConverters.GatewayGetFilesOrderNullableJsonConverter),

            typeof(global::Writer.JsonConverters.GatewayGetFilesStatusJsonConverter),

            typeof(global::Writer.JsonConverters.GatewayGetFilesStatusNullableJsonConverter),

            typeof(global::Writer.JsonConverters.OrderJsonConverter),

            typeof(global::Writer.JsonConverters.OrderNullableJsonConverter),

            typeof(global::Writer.JsonConverters.ApplicationInputOptionsJsonConverter),

            typeof(global::Writer.JsonConverters.ToolJsonConverter),

            typeof(global::Writer.JsonConverters.ToolChoiceJsonConverter),

            typeof(global::Writer.JsonConverters.CompositeContentJsonConverter),

            typeof(global::Writer.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<string>, string>),

            typeof(global::Writer.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<string>, string>),

            typeof(global::Writer.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Writer.CompositeContent>>),

            typeof(global::Writer.JsonConverters.OneOfJsonConverter<global::Writer.WebSearchRequestIncludeRawContent?, bool?>),

            typeof(global::Writer.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.ModelInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.ModelsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Writer.ModelInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.Logprobs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Writer.LogprobsToken>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.LogprobsToken))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Writer.TopLogProb>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.TopLogProb))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.CompletionsChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.CompletionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Writer.CompletionsChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.StreamingData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.Map))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.CompletionsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.OneOf<global::System.Collections.Generic.IList<string>, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.FailMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.FailResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Writer.FailMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.ChatCompletionChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.ChatCompletionFinishReason))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.ChatCompletionResponseMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.ChatCompletionStreamingChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.ChatCompletionStreamingDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.ChatRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Writer.ChatMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.ChatMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Writer.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.Tool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.ToolChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.StreamOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.ResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.ResponseFormatType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.ChatResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.ChatResponseObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Writer.ChatCompletionChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.ChatCompletionUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.ChatCompletionChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.ChatCompletionChunkObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Writer.ChatCompletionStreamingChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.ChatCompletionResponseMessageRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Writer.ToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.ToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.GraphData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.LlmData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.TranslationData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.WebSearchData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.ChatMessageRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Writer.ToolCallStreaming>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.ToolCallStreaming))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.PromptTokenDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.CompletionTokenDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.OneOf<string, global::System.Collections.Generic.IList<global::Writer.CompositeContent>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Writer.CompositeContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.CompositeContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.ChatMessageRequestRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.DeleteFileResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.RetryFilesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.FileResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.GraphType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.FilesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Writer.FileResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.ApplicationGraphIdsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.ApplicationGraphsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Writer.Source>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.Source))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.GraphStageStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Writer.SubQuery>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.SubQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.References))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Writer.WebSearchDataSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.WebSearchDataSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.GraphResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Writer.WebConnectorUrl>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.WebConnectorUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.DeleteGraphResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.RetryFilesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.GraphFileRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.GraphFileStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.GraphRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.UpdateGraphRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Writer.UpdateGraphWebUrl>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.UpdateGraphWebUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.WebConnectorUrlType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.GraphsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Writer.Graph>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.Graph))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.WebConnectorUrlState))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.WebConnectorUrlStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.WebConnectorUrlErrorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.GenerateApplicationInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.GenerateApplicationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Writer.GenerateApplicationInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.GetAsyncApplicationJobsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Writer.GetAsyncApplicationJobResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.GetAsyncApplicationJobResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.GetAsyncApplicationJobsResponsePagination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.ApiJobStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.GenerateApplicationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.GenerateApplicationAsyncRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.GenerateApplicationAsyncResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.RetryAsyncApplicationJobResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.ApplicationType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.GetApplicationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Writer.ApplicationWithInputs>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.ApplicationWithInputs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.ApplicationStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Writer.ApplicationInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.ApplicationInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.ApplicationInputType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.ApplicationInputOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.ApplicationInputDropdownOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.ApplicationInputFileOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.ApplicationInputMediaOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.ApplicationInputTextOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Writer.FileUploadType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.FileUploadType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.GenerateApplicationResponseChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.GenerateApplicationDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Writer.GenerateApplicationChunkStage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.GenerateApplicationChunkStage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.QuestionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.GraphQueryConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.QuestionResponseChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.QuestionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.FunctionTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.GraphTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.LlmTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.TranslationTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.VisionTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.WebSearchTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.ToolDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.ToolDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.FunctionToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.ToolFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.GraphToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.GraphFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.LlmToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.LlmFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.VisionToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.VisionFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Writer.VisionToolRequestFileVariable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.VisionToolRequestFileVariable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.VisionFunctionModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.ToolCallType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.Function))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.ToolCallStreamingType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.StringToolChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.JsonObjectToolChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.StringToolChoiceOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.AiDetectionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.AiDetectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.AiDetectionResponseLabel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.ComprehendMedicalRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.ComprehendMedicalType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.MedicalComprehendResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Writer.MedicalComprehendEntity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.MedicalComprehendEntity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Writer.MedicalComprehendTrait>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.MedicalComprehendTrait))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Writer.MedicalComprehendConcept>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.MedicalComprehendConcept))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Writer.MedicalComprehendAttribute>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.MedicalComprehendAttribute))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.ContextAwareTextSplittingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.SplittingStrategy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.ContextAwareSplittingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.ParsePdfRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.PdfConversionFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.ParsePdfResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.TextToGraphRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.TextToGraphResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.VisionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.VisionRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Writer.VisionRequestFileVariable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.VisionRequestFileVariable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.VisionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.TranslationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.TranslationRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.TranslationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.TranslationToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.TranslationFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.TranslationFunctionModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.WebSearchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.WebSearchRequestTopic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.WebSearchRequestSearchDepth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.WebSearchRequestTimeRange))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.OneOf<global::Writer.WebSearchRequestIncludeRawContent?, bool?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.WebSearchRequestIncludeRawContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.WebSearchRequestCountry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.WebSearchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Writer.WebSearchResponseSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.WebSearchResponseSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.WebSearchToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.WebSearchFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.TextFragment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.ImageFragment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.TextFragmentType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.ImageFragmentType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.ImageFragmentImageUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Writer.File>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.File))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Writer.Web>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.Web))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.FindGraphsWithFileStatusOrder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.GatewayGetFilesOrder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.GatewayGetFilesStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.Order))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Writer.ChatCompletionChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Writer.StreamingData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Writer.GenerateApplicationResponseChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Writer.ModelInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Writer.LogprobsToken>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Writer.TopLogProb>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Writer.CompletionsChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.OneOf<global::System.Collections.Generic.List<string>, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Writer.FailMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Writer.ChatMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Writer.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Writer.ChatCompletionChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Writer.ChatCompletionStreamingChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Writer.ToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Writer.ToolCallStreaming>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.OneOf<string, global::System.Collections.Generic.List<global::Writer.CompositeContent>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Writer.CompositeContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Writer.FileResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Writer.Source>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Writer.SubQuery>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Writer.WebSearchDataSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Writer.WebConnectorUrl>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Writer.UpdateGraphWebUrl>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Writer.Graph>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Writer.GenerateApplicationInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Writer.GetAsyncApplicationJobResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Writer.ApplicationWithInputs>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Writer.ApplicationInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Writer.FileUploadType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Writer.GenerateApplicationChunkStage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Writer.VisionToolRequestFileVariable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Writer.MedicalComprehendEntity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Writer.MedicalComprehendTrait>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Writer.MedicalComprehendConcept>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Writer.MedicalComprehendAttribute>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Writer.VisionRequestFileVariable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Writer.WebSearchResponseSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Writer.File>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Writer.Web>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Writer.ChatCompletionChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Writer.StreamingData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Writer.GenerateApplicationResponseChunk>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}