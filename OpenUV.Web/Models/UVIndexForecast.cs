using System.Text.Json.Serialization;

namespace OpenUV.Web.Models
{
    public class UVIndexForecast
    {
        [JsonPropertyName("uv")]
        public double UV { get; set; } = default!;

        [JsonPropertyName("uv_time")]
        [JsonConverter(typeof(Converters.DateTimeConverter))]
        public DateTime Sunrise { get; set; } = default!;

        [JsonPropertyName("sun_position")]
        public SunPosition SunPosition { get; set; } = default!;
    }
}
