using APIDashboard.CrossCutting.Models;
using APIDashboard.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIDashboard.Domain.Orchestrators
{
    public class WeatherOrchestrator
    {
        private WeatherRepository weatherRepository;

        public WeatherOrchestrator()
        {
            weatherRepository = new WeatherRepository();
        }

        public CurrentWeather.Rootobject GetCurrentWeather()
        {
            CurrentWeather.Rootobject weather = weatherRepository.GetCurrentWeather().Result;

            if (weather == null)
            {
                return null;
            }

            weather.weather[0].icon = $"http://openweathermap.org/img/w/{weather.weather[0].icon}.png";

            return weather;
        }
    }
}
