using APIDashboard.CrossCutting.Models;
using System.Reflection.Metadata.Ecma335;

namespace APIDashboard.Web.UI.Models
{
    public class DashboardIndexViewModel
    {
        public string QuoteContent { get; set; }

        public string QuoteAuthor { get; set; }

        public DashboardIndexViewModel(Quote quote)
        {
            QuoteContent = quote.content;
            QuoteAuthor = quote.author;
        }
    }
}

