using System.Text.Json.Serialization;

namespace OpenUV.Web.Models
{
    public class ApiStatistics
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
        public double CostToday { get; set; } = default!;

        [JsonPropertyName("cost_yesterday")]
        public double CostYesterday { get; set; } = default!;

        [JsonPropertyName("cost_month")]
        public double CostThisMonth { get; set; } = default!;

        [JsonPropertyName("cost_last_month")]
        public double CostLastMonth { get; set; } = default!;
    }
}
