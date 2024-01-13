using System.Text.Json.Serialization;

namespace OpenUV.Web.Models
{
    public class Statistics
    {
        [JsonPropertyName("requests_today")]
        public uint RequestsToday { get; set; } = default!;

        [JsonPropertyName("requests_yesterday")]
        public uint RequestsYesterday { get; set; } = default!;

        [JsonPropertyName("requests_month")]
        public uint RequestsThisMonth { get; set; } = default!;

        [JsonPropertyName("requests_last_month")]
        public uint RequestsLastMonth { get; set; } = default!;

        [JsonPropertyName("cost_today")]
        public uint CostToday { get; set; } = default!;

        [JsonPropertyName("cost_yesterday")]
        public uint CostYesterday { get; set; } = default!;

        [JsonPropertyName("cost_month")]
        public uint CostThisMonth { get; set; } = default!;

        [JsonPropertyName("cost_last_month")]
        public uint CostLastMonth { get; set; } = default!;
    }
}
