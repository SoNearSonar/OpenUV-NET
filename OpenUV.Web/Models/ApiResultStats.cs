using System.Text.Json.Serialization;

namespace OpenUV.Web.Models
{
    internal class ApiResultStats
    {
        [JsonPropertyName("result")]
        public Statistics Statistics { get; set; } = default!;
    }
}
