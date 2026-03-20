
#nullable enable

namespace Writer
{
    /// <summary>
    /// 
    /// </summary>
    public enum GraphStageStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Processing,
        /// <summary>
        /// 
        /// </summary>
        Finished,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GraphStageStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GraphStageStatus value)
        {
            return value switch
            {
                GraphStageStatus.Processing => "processing",
                GraphStageStatus.Finished => "finished",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GraphStageStatus? ToEnum(string value)
        {
            return value switch
            {
                "processing" => GraphStageStatus.Processing,
                "finished" => GraphStageStatus.Finished,
                _ => null,
            };
        }
    }
}