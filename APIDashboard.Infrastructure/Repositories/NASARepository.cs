using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIDashboard.CrossCutting.Models;
using Newtonsoft.Json;

namespace APIDashboard.Infrastructure.Repositories
{
    public class NASARepository
    {

        private static readonly string url = "https://api.nasa.gov";

        private static readonly string apiKey = "fkxv5cM4RWXeeWx9L37rSWR394Tyrwofdnig8Lmd";

        private static readonly string apodEndpoint = "/planetary/apod";

        private Random rnd = new Random();


        public async Task<APOD> GetAPOD()
        {
            APOD apod;

            using HttpClient client = new HttpClient();

            HttpResponseMessage response = await client.GetAsync($"{url}{apodEndpoint}?api_key={apiKey}&date=2020-01-{rnd.Next(0, 3)}{rnd.Next(1, 10)}");

            string result = response.Content.ReadAsStringAsync().Result;

            apod = JsonConvert.DeserializeObject<APOD>(result);

            return apod;
        }
    }
}
