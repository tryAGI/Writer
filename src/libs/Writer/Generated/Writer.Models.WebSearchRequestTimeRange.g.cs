
#nullable enable

namespace Writer
{
    /// <summary>
    /// Filters results to content published within the specified time range back from the current date. For example, `week` or `w` returns results from the past 7 days.
    /// </summary>
    public enum WebSearchRequestTimeRange
    {
        /// <summary>
        /// 
        /// </summary>
        Day,
        /// <summary>
        /// 
        /// </summary>
        Week,
        /// <summary>
        /// 
        /// </summary>
        Month,
        /// <summary>
        /// 
        /// </summary>
        Year,
        /// <summary>
        /// 
        /// </summary>
        D,
        /// <summary>
        /// 
        /// </summary>
        W,
        /// <summary>
        /// 
        /// </summary>
        M,
        /// <summary>
        /// 
        /// </summary>
        Y,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebSearchRequestTimeRangeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSearchRequestTimeRange value)
        {
            return value switch
            {
                WebSearchRequestTimeRange.Day => "day",
                WebSearchRequestTimeRange.Week => "week",
                WebSearchRequestTimeRange.Month => "month",
                WebSearchRequestTimeRange.Year => "year",
                WebSearchRequestTimeRange.D => "d",
                WebSearchRequestTimeRange.W => "w",
                WebSearchRequestTimeRange.M => "m",
                WebSearchRequestTimeRange.Y => "y",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSearchRequestTimeRange? ToEnum(string value)
        {
            return value switch
            {
                "day" => WebSearchRequestTimeRange.Day,
                "week" => WebSearchRequestTimeRange.Week,
                "month" => WebSearchRequestTimeRange.Month,
                "year" => WebSearchRequestTimeRange.Year,
                "d" => WebSearchRequestTimeRange.D,
                "w" => WebSearchRequestTimeRange.W,
                "m" => WebSearchRequestTimeRange.M,
                "y" => WebSearchRequestTimeRange.Y,
                _ => null,
            };
        }
    }
}