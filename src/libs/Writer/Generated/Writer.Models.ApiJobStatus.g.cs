
#nullable enable

namespace Writer
{
    /// <summary>
    /// The status of the job.
    /// </summary>
    public enum ApiJobStatus
    {
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Completed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiJobStatus value)
        {
            return value switch
            {
                ApiJobStatus.InProgress => "in_progress",
                ApiJobStatus.Failed => "failed",
                ApiJobStatus.Completed => "completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "in_progress" => ApiJobStatus.InProgress,
                "failed" => ApiJobStatus.Failed,
                "completed" => ApiJobStatus.Completed,
                _ => null,
            };
        }
    }
}