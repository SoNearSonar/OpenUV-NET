using System.Text.Json.Serialization;

namespace OpenUV.Web.Models
{
    public class SunPosition
    {
        [JsonPropertyName("azimuth")]
        public double Azimuth { get; set; } = default!;

        [JsonPropertyName("altitude")]
        public double Altitude { get; set; } = default!;
    }
}
