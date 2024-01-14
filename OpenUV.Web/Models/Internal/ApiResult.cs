using System.Text.Json.Serialization;

namespace OpenUV.Web.Models.Internal
{
    internal class ApiResult
    {
        [JsonPropertyName("result")]
        public ApiStatistics Statistics { get; set; } = default!;
    }
}
