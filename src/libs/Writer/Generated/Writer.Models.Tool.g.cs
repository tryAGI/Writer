#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Writer
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Tool : global::System.IEquatable<Tool>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Writer.ToolDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Writer.FunctionTool? Function { get; init; }
#else
        public global::Writer.FunctionTool? Function { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Function))]
#endif
        public bool IsFunction => Function != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Writer.GraphTool? Graph { get; init; }
#else
        public global::Writer.GraphTool? Graph { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Graph))]
#endif
        public bool IsGraph => Graph != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Writer.LlmTool? Llm { get; init; }
#else
        public global::Writer.LlmTool? Llm { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Llm))]
#endif
        public bool IsLlm => Llm != null;

        /// <summary>
        /// A tool that uses Palmyra Translate to translate text. Note that this tool does not stream results. The response is returned after the translation is complete.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Writer.TranslationTool? Translation { get; init; }
#else
        public global::Writer.TranslationTool? Translation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Translation))]
#endif
        public bool IsTranslation => Translation != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Writer.VisionTool? Vision { get; init; }
#else
        public global::Writer.VisionTool? Vision { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Vision))]
#endif
        public bool IsVision => Vision != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Writer.WebSearchTool? WebSearch { get; init; }
#else
        public global::Writer.WebSearchTool? WebSearch { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebSearch))]
#endif
        public bool IsWebSearch => WebSearch != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::Writer.FunctionTool value) => new Tool((global::Writer.FunctionTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Writer.FunctionTool?(Tool @this) => @this.Function;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::Writer.FunctionTool? value)
        {
            Function = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::Writer.GraphTool value) => new Tool((global::Writer.GraphTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Writer.GraphTool?(Tool @this) => @this.Graph;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::Writer.GraphTool? value)
        {
            Graph = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::Writer.LlmTool value) => new Tool((global::Writer.LlmTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Writer.LlmTool?(Tool @this) => @this.Llm;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::Writer.LlmTool? value)
        {
            Llm = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::Writer.TranslationTool value) => new Tool((global::Writer.TranslationTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Writer.TranslationTool?(Tool @this) => @this.Translation;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::Writer.TranslationTool? value)
        {
            Translation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::Writer.VisionTool value) => new Tool((global::Writer.VisionTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Writer.VisionTool?(Tool @this) => @this.Vision;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::Writer.VisionTool? value)
        {
            Vision = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::Writer.WebSearchTool value) => new Tool((global::Writer.WebSearchTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Writer.WebSearchTool?(Tool @this) => @this.WebSearch;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::Writer.WebSearchTool? value)
        {
            WebSearch = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Tool(
            global::Writer.ToolDiscriminatorType? type,
            global::Writer.FunctionTool? function,
            global::Writer.GraphTool? graph,
            global::Writer.LlmTool? llm,
            global::Writer.TranslationTool? translation,
            global::Writer.VisionTool? vision,
            global::Writer.WebSearchTool? webSearch
            )
        {
            Type = type;

            Function = function;
            Graph = graph;
            Llm = llm;
            Translation = translation;
            Vision = vision;
            WebSearch = webSearch;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            WebSearch as object ??
            Vision as object ??
            Translation as object ??
            Llm as object ??
            Graph as object ??
            Function as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Function?.ToString() ??
            Graph?.ToString() ??
            Llm?.ToString() ??
            Translation?.ToString() ??
            Vision?.ToString() ??
            WebSearch?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFunction && !IsGraph && !IsLlm && !IsTranslation && !IsVision && !IsWebSearch || !IsFunction && IsGraph && !IsLlm && !IsTranslation && !IsVision && !IsWebSearch || !IsFunction && !IsGraph && IsLlm && !IsTranslation && !IsVision && !IsWebSearch || !IsFunction && !IsGraph && !IsLlm && IsTranslation && !IsVision && !IsWebSearch || !IsFunction && !IsGraph && !IsLlm && !IsTranslation && IsVision && !IsWebSearch || !IsFunction && !IsGraph && !IsLlm && !IsTranslation && !IsVision && IsWebSearch;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Writer.FunctionTool?, TResult>? function = null,
            global::System.Func<global::Writer.GraphTool?, TResult>? graph = null,
            global::System.Func<global::Writer.LlmTool?, TResult>? llm = null,
            global::System.Func<global::Writer.TranslationTool?, TResult>? translation = null,
            global::System.Func<global::Writer.VisionTool?, TResult>? vision = null,
            global::System.Func<global::Writer.WebSearchTool?, TResult>? webSearch = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFunction && function != null)
            {
                return function(Function!);
            }
            else if (IsGraph && graph != null)
            {
                return graph(Graph!);
            }
            else if (IsLlm && llm != null)
            {
                return llm(Llm!);
            }
            else if (IsTranslation && translation != null)
            {
                return translation(Translation!);
            }
            else if (IsVision && vision != null)
            {
                return vision(Vision!);
            }
            else if (IsWebSearch && webSearch != null)
            {
                return webSearch(WebSearch!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Writer.FunctionTool?>? function = null,
            global::System.Action<global::Writer.GraphTool?>? graph = null,
            global::System.Action<global::Writer.LlmTool?>? llm = null,
            global::System.Action<global::Writer.TranslationTool?>? translation = null,
            global::System.Action<global::Writer.VisionTool?>? vision = null,
            global::System.Action<global::Writer.WebSearchTool?>? webSearch = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFunction)
            {
                function?.Invoke(Function!);
            }
            else if (IsGraph)
            {
                graph?.Invoke(Graph!);
            }
            else if (IsLlm)
            {
                llm?.Invoke(Llm!);
            }
            else if (IsTranslation)
            {
                translation?.Invoke(Translation!);
            }
            else if (IsVision)
            {
                vision?.Invoke(Vision!);
            }
            else if (IsWebSearch)
            {
                webSearch?.Invoke(WebSearch!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Function,
                typeof(global::Writer.FunctionTool),
                Graph,
                typeof(global::Writer.GraphTool),
                Llm,
                typeof(global::Writer.LlmTool),
                Translation,
                typeof(global::Writer.TranslationTool),
                Vision,
                typeof(global::Writer.VisionTool),
                WebSearch,
                typeof(global::Writer.WebSearchTool),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(Tool other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Writer.FunctionTool?>.Default.Equals(Function, other.Function) &&
                global::System.Collections.Generic.EqualityComparer<global::Writer.GraphTool?>.Default.Equals(Graph, other.Graph) &&
                global::System.Collections.Generic.EqualityComparer<global::Writer.LlmTool?>.Default.Equals(Llm, other.Llm) &&
                global::System.Collections.Generic.EqualityComparer<global::Writer.TranslationTool?>.Default.Equals(Translation, other.Translation) &&
                global::System.Collections.Generic.EqualityComparer<global::Writer.VisionTool?>.Default.Equals(Vision, other.Vision) &&
                global::System.Collections.Generic.EqualityComparer<global::Writer.WebSearchTool?>.Default.Equals(WebSearch, other.WebSearch) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Tool obj1, Tool obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Tool>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Tool obj1, Tool obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Tool o && Equals(o);
        }
    }
}
