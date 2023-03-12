using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIDashboard.CrossCutting.Models;
using Newtonsoft.Json;

namespace APIDashboard.Infrastructure.Repositories
{
    public class WeatherRepository
    {
        private static readonly string url = "https://api.openweathermap.org/data/2.5";

        private static readonly string apiKey = "86131be4e5fab52c2df14d560acfc04a";

        private static readonly string weatherEndpoint = "/weather";
        public async Task<CurrentWeather.Rootobject> GetCurrentWeather()
        {
            double lat = 42.7;
            double lon = -82.93;

            CurrentWeather.Rootobject weather;

            using HttpClient client = new HttpClient();

            HttpResponseMessage response = await client.GetAsync($"{url}{weatherEndpoint}?units=imperial&lat={lat}&lon={lon}&appid={apiKey}");

            string result = response.Content.ReadAsStringAsync().Result;

            weather = JsonConvert.DeserializeObject<CurrentWeather.Rootobject>(result);

            return weather;
        }
    }
}
