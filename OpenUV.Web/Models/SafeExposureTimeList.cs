using System.Text.Json.Serialization;

namespace OpenUV.Web.Models
{
    // SafeExposureTime can have values that are null so make these unsigned ints nullable
    public class SafeExposureTimeList
    {
        [JsonPropertyName("st1")]
        public uint? SafeTimeOne { get; set; } = default!;

        [JsonPropertyName("st2")]
        public uint? SafeTimeTwo { get; set; } = default!;

        [JsonPropertyName("st3")]
        public uint? SafeTimeThree { get; set; } = default!;

        [JsonPropertyName("st4")]
        public uint? SafeTimeFour { get; set; } = default!;

        [JsonPropertyName("st5")]
        public uint? SafeTimeFive { get; set; } = default!;

        [JsonPropertyName("st6")]
        public uint? SafeTimeSix { get; set; } = default!;
    }
}
