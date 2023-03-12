using APIDashboard.CrossCutting.Models;
using System.Reflection.Metadata.Ecma335;

namespace APIDashboard.Web.UI.Models
{
    public class DashboardIndexViewModel
    {
        
    }

    public class QuoteViewModel
    {
        public string id { get; set; }

        public string content { get; set; }

        public string author { get; set; }

        public string authorSlug { get; set; }

        public int length { get; set; }

        public string[] tags { get; set; }

        public QuoteViewModel(Quote quote)
        {
            id = quote.id;
            content = quote.content;
            author = quote.author;
            authorSlug = quote.authorSlug;
            length = quote.length;
            tags = quote.tags;
        }
    }
}
