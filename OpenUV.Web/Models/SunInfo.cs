using System.Text.Json.Serialization;

namespace OpenUV.Web.Models
{
    public class SunInfo
    {
        [JsonPropertyName("sun_times")]
        public SunTimes SunTimes { get; set; } = default!;

        [JsonPropertyName("sun_position")]
        public SunPosition SunPosition { get; set; } = default!;
    }
}
