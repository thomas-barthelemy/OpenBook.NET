namespace OpenBook.Models.ApiResults.MarketCategories
{
    public class SymbolRatesModelData
    {
        public double SentimentPercent { get; set; }
        public string SentimentType { get; set; }
        public RatesData Rates { get; set; }
        public int InstrumentID { get; set; }
        public double? PeriodChangePrecent { get; set; }
        public double? PeriodChangeValue { get; set; }
    }
}
