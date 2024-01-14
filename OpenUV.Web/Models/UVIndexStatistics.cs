using System.Text.Json.Serialization;

namespace OpenUV.Web.Models
{
    public class UVIndexStatistics
    {
        [JsonPropertyName("uv")]
        public uint UV { get; set; } = default!;

        [JsonPropertyName("uv_time")]
        [JsonConverter(typeof(Converters.DateTimeConverter))]
        public DateTime UVTime { get; set; } = default!;

        [JsonPropertyName("uv_max")]
        public double UVMax { get; set; } = default!;

        [JsonPropertyName("uv_max_time")]
        [JsonConverter(typeof(Converters.DateTimeConverter))]
        public DateTime UVMaxTime { get; set; } = default!;

        [JsonPropertyName("ozone")]
        public double Ozone { get; set; } = default!;

        [JsonPropertyName("ozone_time")]
        [JsonConverter(typeof(Converters.DateTimeConverter))]
        public DateTime OzoneTime { get; set; } = default!;

        [JsonPropertyName("safe_exposure_time")]
        public SafeExposureTimeList SafeExposureTimeList { get; set; } = default!;

        [JsonPropertyName("sun_info")]
        public SunInfo SunInfo { get; set; } = default!;
    }
}
