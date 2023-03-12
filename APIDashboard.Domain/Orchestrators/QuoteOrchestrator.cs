using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIDashboard.CrossCutting.Models;
using APIDashboard.Infrastructure.Repositories;

namespace APIDashboard.Domain.Orchestrators
{
    public class QuoteOrchestrator
    {
        private QuoteRepository quoteRepository;

        public QuoteOrchestrator()
        {
            quoteRepository = new QuoteRepository();
        }

        public Quote GetRandomQuote()
        {
            Quote quote = quoteRepository.GetRandomQuote().Result;

            if (quote == null)
            {
                return null;
            }

            return quote;
        }
    }
}
