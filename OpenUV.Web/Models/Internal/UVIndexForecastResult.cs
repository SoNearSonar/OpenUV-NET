using System.Text.Json.Serialization;

namespace OpenUV.Web.Models.Internal
{
    internal class UVIndexForecastResult
    {
        [JsonPropertyName("result")]
        public List<UVIndexForecast> UVIndexForecasts { get; set; } = default!;
    }
}
