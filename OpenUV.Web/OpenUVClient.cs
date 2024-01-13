using OpenUV.Web.Models;
using System.Text.Json;

namespace OpenUV.Web
{
    public class OpenUVClient
    {
        private readonly string _url = "https://api.openuv.io/api/v1";
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

        public async Task<Statistics> GetApiRequestStats()
        {
            var message = await _httpClient.GetAsync(_url + "/stat");
            if (message.IsSuccessStatusCode)
            {
                string result = await message.Content.ReadAsStringAsync();
                return DeserializeObject<ApiResultStats>(result).Statistics;
            }

            throw new HttpRequestException($"{(int)message.StatusCode} {message.StatusCode} code - Request was not successful");
        }

        public static T DeserializeObject<T>(string json)
        {
            var options = new JsonSerializerOptions(JsonSerializerDefaults.Web);
            return JsonSerializer.Deserialize<T>(json, options);
        }
    }
}