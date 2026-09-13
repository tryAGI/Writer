
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.DeleteFileResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.FileResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.GraphType), TypeInfoPropertyName = "GraphType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Writer.Source?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.Source))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Writer.SubQuery?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.SubQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.References))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.GraphResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Writer.WebConnectorUrl>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.WebConnectorUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<long>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.DeleteGraphResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.GraphFileRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.GraphFileStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.GraphRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.UpdateGraphRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Writer.UpdateGraphWebUrl>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.UpdateGraphWebUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.WebConnectorUrlType), TypeInfoPropertyName = "WebConnectorUrlType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.GraphsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Writer.Graph>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.Graph))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.WebConnectorUrlState))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.WebConnectorUrlStatus), TypeInfoPropertyName = "WebConnectorUrlStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.WebConnectorUrlErrorType), TypeInfoPropertyName = "WebConnectorUrlErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.QuestionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.GraphQueryConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.QuestionResponseChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.QuestionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Writer.File>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.File))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Writer.Web>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.Web))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.FindGraphsWithFileStatusOrder), TypeInfoPropertyName = "FindGraphsWithFileStatusOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.GraphType?), TypeInfoPropertyName = "NullableGraphType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.WebConnectorUrlType?), TypeInfoPropertyName = "NullableWebConnectorUrlType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.WebConnectorUrlStatus?), TypeInfoPropertyName = "NullableWebConnectorUrlStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.WebConnectorUrlErrorType?), TypeInfoPropertyName = "NullableWebConnectorUrlErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Writer.FindGraphsWithFileStatusOrder?), TypeInfoPropertyName = "NullableFindGraphsWithFileStatusOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Writer.Source?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Writer.SubQuery?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Writer.WebConnectorUrl>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<long>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Writer.UpdateGraphWebUrl>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Writer.Graph>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Writer.File>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Writer.Web>))]
    internal sealed partial class KgApiSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class KgApiSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static KgApiSourceGenerationContext Default { get; } = new(DefaultOptions);

        private KgApiSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Writer.GraphType)

                    || typeToConvert == typeof(global::Writer.GraphType?)

                    || typeToConvert == typeof(global::Writer.WebConnectorUrlType)

                    || typeToConvert == typeof(global::Writer.WebConnectorUrlType?)

                    || typeToConvert == typeof(global::Writer.WebConnectorUrlErrorType)

                    || typeToConvert == typeof(global::Writer.WebConnectorUrlErrorType?)

                    || typeToConvert == typeof(global::Writer.WebConnectorUrlStatus)

                    || typeToConvert == typeof(global::Writer.WebConnectorUrlStatus?)

                    || typeToConvert == typeof(global::Writer.FindGraphsWithFileStatusOrder)

                    || typeToConvert == typeof(global::Writer.FindGraphsWithFileStatusOrder?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Writer.GraphType))
                {
                    return new global::Writer.JsonConverters.GraphTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Writer.GraphType?))
                {
                    return new global::Writer.JsonConverters.GraphTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Writer.WebConnectorUrlType))
                {
                    return new global::Writer.JsonConverters.WebConnectorUrlTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Writer.WebConnectorUrlType?))
                {
                    return new global::Writer.JsonConverters.WebConnectorUrlTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Writer.WebConnectorUrlErrorType))
                {
                    return new global::Writer.JsonConverters.WebConnectorUrlErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Writer.WebConnectorUrlErrorType?))
                {
                    return new global::Writer.JsonConverters.WebConnectorUrlErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Writer.WebConnectorUrlStatus))
                {
                    return new global::Writer.JsonConverters.WebConnectorUrlStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Writer.WebConnectorUrlStatus?))
                {
                    return new global::Writer.JsonConverters.WebConnectorUrlStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Writer.FindGraphsWithFileStatusOrder))
                {
                    return new global::Writer.JsonConverters.FindGraphsWithFileStatusOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::Writer.FindGraphsWithFileStatusOrder?))
                {
                    return new global::Writer.JsonConverters.FindGraphsWithFileStatusOrderNullableJsonConverter();
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
                    0 => new KgApiSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}