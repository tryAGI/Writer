
#nullable enable

namespace Writer
{
    /// <summary>
    /// Type of file upload method supported by the application.
    /// </summary>
    public enum FileUploadType
    {
        /// <summary>
        /// 
        /// </summary>
        Url,
        /// <summary>
        /// 
        /// </summary>
        FileId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileUploadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileUploadType value)
        {
            return value switch
            {
                FileUploadType.Url => "url",
                FileUploadType.FileId => "file_id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileUploadType? ToEnum(string value)
        {
            return value switch
            {
                "url" => FileUploadType.Url,
                "file_id" => FileUploadType.FileId,
                _ => null,
            };
        }
    }
}