namespace APIDashboard.DebugConsole
{
    using APIDashboard.Infrastructure.Repositories;
    internal class Program
    {
        static async Task Main(string[] args)
        {
            QuoteRepository quoteRepository = new QuoteRepository();

            await quoteRepository.GetRandomQuote();
        }
    }
}