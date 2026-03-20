
#nullable enable

namespace Writer
{
    /// <summary>
    /// 
    /// </summary>
    public enum GatewayGetFilesStatus
    {
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GatewayGetFilesStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GatewayGetFilesStatus value)
        {
            return value switch
            {
                GatewayGetFilesStatus.InProgress => "in_progress",
                GatewayGetFilesStatus.Completed => "completed",
                GatewayGetFilesStatus.Failed => "failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GatewayGetFilesStatus? ToEnum(string value)
        {
            return value switch
            {
                "in_progress" => GatewayGetFilesStatus.InProgress,
                "completed" => GatewayGetFilesStatus.Completed,
                "failed" => GatewayGetFilesStatus.Failed,
                _ => null,
            };
        }
    }
}