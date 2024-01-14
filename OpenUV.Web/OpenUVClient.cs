using OpenUV.Web.Converters;
using OpenUV.Web.Models;
using OpenUV.Web.Models.Internal;
using OpenUV.Web.Utilities;
using System.Text.Json;

namespace OpenUV.Web
{
    public class OpenUVClient
    {
        private readonly static string _url = "https://api.openuv.io/api/v1";
        private static HttpClient _httpClient;

        public OpenUVClient(string apiKey)
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Add("x-access-token", apiKey);
            _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
            _httpClient.DefaultRequestHeaders.Add("User-Agent", "OpenUV-NET/1.0");
        }

        public async Task<bool> GetApiStatus()
        {
            var message = await _httpClient.GetAsync(_url + "/status");
            if (message.IsSuccessStatusCode)
            {
                string result = await message.Content.ReadAsStringAsync();
                return DeserializeObject<ApiStatus>(result).Status;
            }

            throw new HttpRequestException($"{(int)message.StatusCode} {message.StatusCode} code - Request was not successful");
        }

        public async Task<ApiStatistics> GetApiRequestStats()
        {
            var message = await _httpClient.GetAsync(_url + "/stat");
            if (message.IsSuccessStatusCode)
            {
                string result = await message.Content.ReadAsStringAsync();
                return DeserializeObject<ApiResult>(result).Statistics;
            }

            throw new HttpRequestException($"{(int)message.StatusCode} {message.StatusCode} code - Request was not successful");
        }

        public async Task<UVIndexStatistics> GetUVIndexStatistics(double latitude, double longitude, uint altitude = 100, DateTime time = new DateTime())
        {
            string query = QueryBuilder.FormatQueryParams(latitude, longitude, altitude, time);
            var message = await _httpClient.GetAsync(_url + "/uv" + query);
            if (message.IsSuccessStatusCode)
            {
                string result = await message.Content.ReadAsStringAsync();
                return DeserializeObject<UVIndexResult>(result).UVIndexStatistics;
            }

            throw new HttpRequestException($"{(int)message.StatusCode} {message.StatusCode} code - Request was not successful");
        }

        public static T DeserializeObject<T>(string json)
        {
            var options = new JsonSerializerOptions(JsonSerializerDefaults.Web);
            options.Converters.Add(new DateTimeConverter());
            return JsonSerializer.Deserialize<T>(json, options);
        }
    }
}