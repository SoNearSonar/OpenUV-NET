using System.Text.Json.Serialization;

namespace OpenUV.Web.Models.Internal
{
    internal class ApiStatus
    {
        [JsonPropertyName("status")]
        public bool Status { get; set; } = default!;
    }
}
