using APIDashboard.CrossCutting.Models;
using APIDashboard.Domain.Orchestrators;
using APIDashboard.Web.UI.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIDashboard.Web.UI.Controllers
{
    public class DashboardController : Controller
    {
        private QuoteOrchestrator quoteOrchestrator;
        private APODOrchestrator apodOrchestrator;
        private WeatherOrchestrator weatherOrchestrator;

        public DashboardController()
        {
            quoteOrchestrator = new QuoteOrchestrator();
            apodOrchestrator = new APODOrchestrator();
            weatherOrchestrator = new WeatherOrchestrator();
        }

        public IActionResult Index()
        {
            Quote quote = quoteOrchestrator.GetRandomQuote();
            APOD apod = apodOrchestrator.GetAPOD();
            CurrentWeather.Rootobject weather = weatherOrchestrator.GetCurrentWeather();
            DashboardIndexViewModel viewModel = new DashboardIndexViewModel(quote, apod, weather);
            return View(viewModel);
        }
    }
}
