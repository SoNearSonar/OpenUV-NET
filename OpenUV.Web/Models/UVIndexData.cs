using System.Text.Json.Serialization;

namespace OpenUV.Web.Models
{
    internal class UVIndexData
    {
        [JsonPropertyName("result")]
        public UVIndexStatistics UVIndexStatistics { get; set; } = default!;
    }
}
