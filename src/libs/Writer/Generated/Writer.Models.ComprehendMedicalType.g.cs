
#nullable enable

namespace Writer
{
    /// <summary>
    /// 
    /// </summary>
    public enum ComprehendMedicalType
    {
        /// <summary>
        /// 
        /// </summary>
        Entities,
        /// <summary>
        /// 
        /// </summary>
        RxNorm,
        /// <summary>
        /// 
        /// </summary>
        Icd10Cm,
        /// <summary>
        /// 
        /// </summary>
        SnomedCt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ComprehendMedicalTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComprehendMedicalType value)
        {
            return value switch
            {
                ComprehendMedicalType.Entities => "Entities",
                ComprehendMedicalType.RxNorm => "RxNorm",
                ComprehendMedicalType.Icd10Cm => "ICD-10-CM",
                ComprehendMedicalType.SnomedCt => "SNOMED CT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComprehendMedicalType? ToEnum(string value)
        {
            return value switch
            {
                "Entities" => ComprehendMedicalType.Entities,
                "RxNorm" => ComprehendMedicalType.RxNorm,
                "ICD-10-CM" => ComprehendMedicalType.Icd10Cm,
                "SNOMED CT" => ComprehendMedicalType.SnomedCt,
                _ => null,
            };
        }
    }
}