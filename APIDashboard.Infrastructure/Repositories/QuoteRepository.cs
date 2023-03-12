using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using APIDashboard.CrossCutting.Models;

namespace APIDashboard.Infrastructure.Repositories
{
    public class QuoteRepository
    {
        private static readonly string url = "https://api.quotable.io";

        public async Task<Quote> GetRandomQuote()
        {
            Quote quote;

            using HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync($"{url}/random");
            string result = response.Content.ReadAsStringAsync().Result;
            quote = Newtonsoft.Json.JsonConvert.DeserializeObject<Quote>(result);
            return quote;
        }
    }
}
