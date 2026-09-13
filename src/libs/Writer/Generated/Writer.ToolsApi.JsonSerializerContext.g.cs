
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
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.ParsePdfRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.PdfConversionFormat), TypeInfoPropertyName = "PdfConversionFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.ParsePdfResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.WebSearchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.WebSearchRequestTopic), TypeInfoPropertyName = "WebSearchRequestTopic2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.WebSearchRequestSearchDepth), TypeInfoPropertyName = "WebSearchRequestSearchDepth2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.WebSearchRequestTimeRange), TypeInfoPropertyName = "WebSearchRequestTimeRange2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.OneOf<global::Writer.WebSearchRequestIncludeRawContent?, bool?>), TypeInfoPropertyName = "OneOfWebSearchRequestIncludeRawContentBoolean2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.WebSearchRequestIncludeRawContent), TypeInfoPropertyName = "WebSearchRequestIncludeRawContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.WebSearchRequestCountry), TypeInfoPropertyName = "WebSearchRequestCountry2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.WebSearchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Writer.WebSearchResponseSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.WebSearchResponseSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.PdfConversionFormat?), TypeInfoPropertyName = "NullablePdfConversionFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.WebSearchRequestTopic?), TypeInfoPropertyName = "NullableWebSearchRequestTopic2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.WebSearchRequestSearchDepth?), TypeInfoPropertyName = "NullableWebSearchRequestSearchDepth2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.WebSearchRequestTimeRange?), TypeInfoPropertyName = "NullableWebSearchRequestTimeRange2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.OneOf<global::Writer.WebSearchRequestIncludeRawContent?, bool?>?), TypeInfoPropertyName = "NullableOneOfWebSearchRequestIncludeRawContentBoolean2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.WebSearchRequestIncludeRawContent?), TypeInfoPropertyName = "NullableWebSearchRequestIncludeRawContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.WebSearchRequestCountry?), TypeInfoPropertyName = "NullableWebSearchRequestCountry2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Writer.WebSearchResponseSource>))]
    internal sealed partial class ToolsApiSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ToolsApiSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ToolsApiSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ToolsApiSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Writer.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Writer.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Writer.JsonConverters.OneOfJsonConverter<global::Writer.WebSearchRequestIncludeRawContent?, bool?>());
            options.Converters.Add(new global::Writer.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Writer.PdfConversionFormat)

                    || typeToConvert == typeof(global::Writer.PdfConversionFormat?)

                    || typeToConvert == typeof(global::Writer.WebSearchRequestTopic)

                    || typeToConvert == typeof(global::Writer.WebSearchRequestTopic?)

                    || typeToConvert == typeof(global::Writer.WebSearchRequestSearchDepth)

                    || typeToConvert == typeof(global::Writer.WebSearchRequestSearchDepth?)

                    || typeToConvert == typeof(global::Writer.WebSearchRequestTimeRange)

                    || typeToConvert == typeof(global::Writer.WebSearchRequestTimeRange?)

                    || typeToConvert == typeof(global::Writer.WebSearchRequestIncludeRawContent)

                    || typeToConvert == typeof(global::Writer.WebSearchRequestIncludeRawContent?)

                    || typeToConvert == typeof(global::Writer.WebSearchRequestCountry)

                    || typeToConvert == typeof(global::Writer.WebSearchRequestCountry?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Writer.PdfConversionFormat))
                {
                    return new global::Writer.JsonConverters.PdfConversionFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Writer.PdfConversionFormat?))
                {
                    return new global::Writer.JsonConverters.PdfConversionFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Writer.WebSearchRequestTopic))
                {
                    return new global::Writer.JsonConverters.WebSearchRequestTopicJsonConverter();
                }

                if (typeToConvert == typeof(global::Writer.WebSearchRequestTopic?))
                {
                    return new global::Writer.JsonConverters.WebSearchRequestTopicNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Writer.WebSearchRequestSearchDepth))
                {
                    return new global::Writer.JsonConverters.WebSearchRequestSearchDepthJsonConverter();
                }

                if (typeToConvert == typeof(global::Writer.WebSearchRequestSearchDepth?))
                {
                    return new global::Writer.JsonConverters.WebSearchRequestSearchDepthNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Writer.WebSearchRequestTimeRange))
                {
                    return new global::Writer.JsonConverters.WebSearchRequestTimeRangeJsonConverter();
                }

                if (typeToConvert == typeof(global::Writer.WebSearchRequestTimeRange?))
                {
                    return new global::Writer.JsonConverters.WebSearchRequestTimeRangeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Writer.WebSearchRequestIncludeRawContent))
                {
                    return new global::Writer.JsonConverters.WebSearchRequestIncludeRawContentJsonConverter();
                }

                if (typeToConvert == typeof(global::Writer.WebSearchRequestIncludeRawContent?))
                {
                    return new global::Writer.JsonConverters.WebSearchRequestIncludeRawContentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Writer.WebSearchRequestCountry))
                {
                    return new global::Writer.JsonConverters.WebSearchRequestCountryJsonConverter();
                }

                if (typeToConvert == typeof(global::Writer.WebSearchRequestCountry?))
                {
                    return new global::Writer.JsonConverters.WebSearchRequestCountryNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new ToolsApiSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}