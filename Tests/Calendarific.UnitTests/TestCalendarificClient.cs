using Xunit;
using Calendarific;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Calendarific.UnitTests
{
    public class TestCalendarificClient
    {
        private readonly CalendarificClient _client;

        public TestCalendarificClient()
        {
            _client = new CalendarificClient("YOUR_API_KEY");
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
                { "year", "2023" }
            };
            var result = await _client.GetHolidaysAsync(parameters);
            Assert.NotNull(result);
        }
    }
}