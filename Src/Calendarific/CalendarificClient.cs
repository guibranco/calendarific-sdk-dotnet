using GuiStracini.SDKBuilder;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http;

namespace Calendarific
{
    public class CalendarificClient
    {
        private readonly HttpClient _httpClient;

        public CalendarificClient(string apiKey)
        {
            _httpClient = new HttpClientBuilder()
                .WithBaseUrl("https://calendarific.com/api/v2/")
                .WithDefaultHeader("api_key", apiKey)
                .Build();
        }

        public async Task<string> GetLanguagesAsync()
        {
            var response = await _httpClient.GetAsync("languages");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetCountriesAsync()
        {
            var response = await _httpClient.GetAsync("countries");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetHolidaysAsync(Dictionary<string, string> parameters)
        {
            var response = await _httpClient.GetAsync($"holidays?{string.Join("&", parameters.Select(kv => $"{kv.Key}={kv.Value}"))}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}