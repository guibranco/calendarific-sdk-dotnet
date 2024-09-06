using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Calendarific
{
    public class CalendarificClient
    {
        private readonly HttpClient _httpClient;

        public CalendarificClient(string apiKey)
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://calendarific.com/api/v2/"),
                DefaultRequestHeaders = { { "api_key", apiKey } },
            };
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
            var response = await _httpClient.GetAsync(
                $"holidays?{string.Join("&", parameters.Select(kv => $"{kv.Key}={kv.Value}"))}"
            );
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}
