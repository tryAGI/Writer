
#nullable enable

namespace Writer
{
    /// <summary>
    /// The type of Knowledge Graph:<br/>
    /// - `manual`: files are uploaded via UI or API<br/>
    /// - `connector`: files are uploaded via a data connector such as Google Drive or Confluence<br/>
    /// - `web`: URLs are connected to the Knowledge Graph
    /// </summary>
    public enum GraphType
    {
        /// <summary>
        /// files are uploaded via UI or API
        /// </summary>
        Manual,
        /// <summary>
        /// files are uploaded via a data connector such as Google Drive or Confluence
        /// </summary>
        Connector,
        /// <summary>
        /// URLs are connected to the Knowledge Graph
        /// </summary>
        Web,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GraphTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GraphType value)
        {
            return value switch
            {
                GraphType.Manual => "manual",
                GraphType.Connector => "connector",
                GraphType.Web => "web",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GraphType? ToEnum(string value)
        {
            return value switch
            {
                "manual" => GraphType.Manual,
                "connector" => GraphType.Connector,
                "web" => GraphType.Web,
                _ => null,
            };
        }
    }
}