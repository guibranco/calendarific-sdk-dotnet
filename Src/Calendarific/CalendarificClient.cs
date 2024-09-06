using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Calendarific
{
    public class CalendarificClient
    {
        private readonly string _apiKey;
        private readonly HttpClient _httpClient;

        public CalendarificClient(string apiKey, HttpClient httpClient)
        {
            _apiKey = apiKey;
            _httpClient = httpClient;
        }

        public async Task<string> GetLanguagesAsync()
        {
            var response = await _httpClient.GetAsync($"languages?api_key={_apiKey}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetCountriesAsync()
        {
            var response = await _httpClient.GetAsync($"countries?api_key={_apiKey}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetHolidaysAsync(Dictionary<string, string> parameters)
        {
            var response = await _httpClient.GetAsync(
                $"holidays?api_key={_apiKey}&{string.Join("&", parameters.Select(kv => $"{kv.Key}={kv.Value}"))}"
            );
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}
