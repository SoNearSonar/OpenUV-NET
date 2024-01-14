using System.Text.Json.Serialization;

namespace OpenUV.Web.Models.Internal
{
    internal class UVIndexResult
    {
        [JsonPropertyName("result")]
        public UVIndexStatistics UVIndexStatistics { get; set; } = default!;
    }
}
