﻿using APIDashboard.CrossCutting.Models;
using APIDashboard.Domain.Orchestrators;
using APIDashboard.Web.UI.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIDashboard.Web.UI.Controllers
{
    public class DashboardController : Controller
    {
        private QuoteOrchestrator quoteOrchestrator;

        public DashboardController()
        {
            quoteOrchestrator = new QuoteOrchestrator();
        }

        public IActionResult Index()
        {
            Quote quote = quoteOrchestrator.GetRandomQuote();
            DashboardIndexViewModel viewModel = new DashboardIndexViewModel(quote);
            return View(viewModel);
        }
    }
}
