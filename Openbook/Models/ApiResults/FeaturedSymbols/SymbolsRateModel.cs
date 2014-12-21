namespace OpenBook.Models.ApiResults.FeaturedSymbols
{
    public struct SymbolRatesModel
    {
        public int InstrumentID;
        public double? PeriodChangePrecent;
        public double? PeriodChangeValue;
        public int Precision;
        public double Price;
    }
}
