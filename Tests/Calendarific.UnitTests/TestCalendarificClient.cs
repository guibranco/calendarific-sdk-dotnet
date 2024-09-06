using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Xunit;

namespace Calendarific.UnitTests
{
    public class TestCalendarificClient
    {
        private readonly CalendarificClient _client;

        public TestCalendarificClient()
        {
            var configuration = new ConfigurationBuilder()
                .AddUserSecrets<TestCalendarificClient>(true)
                .AddEnvironmentVariables()
                .Build();
            var apiKey = string.IsNullOrWhiteSpace(configuration["apiKey"])
                ? "__YOUR_API_KEY_HERE__"
                : configuration["apiKey"];
            var httpClient = new HttpClient()
            {
                BaseAddress = new Uri("https://calendarific.com/api/v2/"),
            };
            _client = new CalendarificClient(apiKey, httpClient);
        }

        [Fact]
        public async Task TestGetLanguagesAsync()
        {
            var result = await _client.GetLanguagesAsync();
            Assert.NotNull(result);
        }

        [Fact]
        public async Task TestGetCountriesAsync()
        {
            var result = await _client.GetCountriesAsync();
            Assert.NotNull(result);
        }

        [Fact]
        public async Task TestGetHolidaysAsync()
        {
            var parameters = new Dictionary<string, string>
            {
                { "country", "US" },
                { "year", "2023" },
            };
            var result = await _client.GetHolidaysAsync(parameters);
            Assert.NotNull(result);
        }
    }
}
