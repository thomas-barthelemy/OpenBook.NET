namespace OpenBook.Models.ApiResults.MarketCategories
{
    public class MarketCategoriesSymbolRatesModel : SymbolsRateModelBase
    {
        public double SentimentPercent { get; set; }
        public string SentimentType { get; set; }
        public Rates Rates { get; set; }
    }
}
