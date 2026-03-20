
#nullable enable

namespace Writer
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum Order
    {
        /// <summary>
        /// 
        /// </summary>
        Asc,
        /// <summary>
        /// 
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Order value)
        {
            return value switch
            {
                Order.Asc => "asc",
                Order.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Order? ToEnum(string value)
        {
            return value switch
            {
                "asc" => Order.Asc,
                "desc" => Order.Desc,
                _ => null,
            };
        }
    }
}