namespace OpenBook.Models.ApiResults.MarketCategories
{
    public struct Rates
    {
        public double Ask;
        public double Bid;
        public int InstrumentID;
        public double? PeriodChangePrecent;
        public double? PeriodChangeValue;
        public double Precision;
    }
}
