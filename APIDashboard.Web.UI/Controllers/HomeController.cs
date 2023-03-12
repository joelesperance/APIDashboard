using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace APIDashboard.Web.UI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}