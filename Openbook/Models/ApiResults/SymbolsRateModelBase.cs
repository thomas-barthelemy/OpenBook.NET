namespace OpenBook.Models.ApiResults
{
    public abstract class SymbolsRateModelBase
    {
        public int InstrumentID { get; set; }
        public double? PeriodChangePrecent { get; set; }
        public double? PeriodChangeValue { get; set; }
    }
}
