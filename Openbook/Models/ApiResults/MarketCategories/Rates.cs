namespace OpenBook.Models.ApiResults.MarketCategories
{
    public class Rates
    {
        public double Ask { get; set; }
        public double Bid { get; set; }
        public int InstrumentID { get; set; }
        public double? PeriodChangePrecent { get; set; }
        public double? PeriodChangeValue { get; set; }
        public double Precision { get; set; }
    }
}
