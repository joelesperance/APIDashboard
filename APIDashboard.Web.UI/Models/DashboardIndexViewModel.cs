using APIDashboard.CrossCutting.Models;
using System.Reflection.Metadata.Ecma335;

namespace APIDashboard.Web.UI.Models
{
    public class DashboardIndexViewModel
    {
        public string QuoteContent { get; set; }

        public string QuoteAuthor { get; set; }

        public string APODImg { get; set; }

        public string WeatherLocation { get; set; }

        public float CurrentTemp {get; set;}

        public string WeatherDescription { get; set; }

        public string WeatherIcon { get; set; }



        public DashboardIndexViewModel(Quote quote, APOD apod, CurrentWeather.Rootobject weather)
        {
            QuoteContent = quote.content;
            QuoteAuthor = quote.author;
            APODImg = apod.Hdurl;
            WeatherLocation = weather.name;
            CurrentTemp = weather.main.temp;
            WeatherDescription = weather.weather[0].description;
            WeatherIcon = weather.weather[0].icon;
        }
    }
}

