using System.Text.Json.Serialization;

namespace OpenUV.Web.Models
{
    public class SunTimes
    {
        [JsonPropertyName("solarNoon")]
        [JsonConverter(typeof(Converters.DateTimeConverter))]
        public DateTime SolarNoon { get; set; } = default!;

        [JsonPropertyName("nadir")]
        [JsonConverter(typeof(Converters.DateTimeConverter))]
        public DateTime Nadir { get; set; } = default!;

        [JsonPropertyName("sunrise")]
        [JsonConverter(typeof(Converters.DateTimeConverter))]
        public DateTime Sunrise { get; set; } = default!;

        [JsonPropertyName("sunset")]
        [JsonConverter(typeof(Converters.DateTimeConverter))]
        public DateTime Sunset { get; set; } = default!;

        [JsonPropertyName("sunriseEnd")]
        [JsonConverter(typeof(Converters.DateTimeConverter))]
        public DateTime SunriseEnd { get; set; } = default!;

        [JsonPropertyName("sunriseStart")]
        [JsonConverter(typeof(Converters.DateTimeConverter))]
        public DateTime SunriseStart { get; set; } = default!;

        [JsonPropertyName("dawn")]
        [JsonConverter(typeof(Converters.DateTimeConverter))]
        public DateTime Dawn { get; set; } = default!;

        [JsonPropertyName("dusk")]
        [JsonConverter(typeof(Converters.DateTimeConverter))]
        public DateTime Dusk { get; set; } = default!;

        [JsonPropertyName("nauticalDawn")]
        [JsonConverter(typeof(Converters.DateTimeConverter))]
        public DateTime NauticalDawn { get; set; } = default!;

        [JsonPropertyName("nauticalDusk")]
        [JsonConverter(typeof(Converters.DateTimeConverter))]
        public DateTime NauticalDusk { get; set; } = default!;

        [JsonPropertyName("nightEnd")]
        [JsonConverter(typeof(Converters.DateTimeConverter))]
        public DateTime NightEnd { get; set; } = default!;

        [JsonPropertyName("night")]
        [JsonConverter(typeof(Converters.DateTimeConverter))]
        public DateTime Night { get; set; } = default!;

        [JsonPropertyName("goldenHourEnd")]
        [JsonConverter(typeof(Converters.DateTimeConverter))]
        public DateTime GoldenHourEnd { get; set; } = default!;

        [JsonPropertyName("goldenHour")]
        [JsonConverter(typeof(Converters.DateTimeConverter))]
        public DateTime GoldenHour { get; set; } = default!;
    }
}
