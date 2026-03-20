
#nullable enable

namespace Writer
{
    /// <summary>
    /// 
    /// </summary>
    public enum SplittingStrategy
    {
        /// <summary>
        /// 
        /// </summary>
        LlmSplit,
        /// <summary>
        /// 
        /// </summary>
        FastSplit,
        /// <summary>
        /// 
        /// </summary>
        HybridSplit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SplittingStrategyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SplittingStrategy value)
        {
            return value switch
            {
                SplittingStrategy.LlmSplit => "llm_split",
                SplittingStrategy.FastSplit => "fast_split",
                SplittingStrategy.HybridSplit => "hybrid_split",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SplittingStrategy? ToEnum(string value)
        {
            return value switch
            {
                "llm_split" => SplittingStrategy.LlmSplit,
                "fast_split" => SplittingStrategy.FastSplit,
                "hybrid_split" => SplittingStrategy.HybridSplit,
                _ => null,
            };
        }
    }
}