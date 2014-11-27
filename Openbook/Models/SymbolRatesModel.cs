using Newtonsoft.Json;

namespace OpenBook.Models
{
    public struct SymbolRatesModel
    {
        public int Precision;
        public double Price;
        public int InstrumentID;
        // ReSharper disable once StringLiteralTypo
        // API has a typo =(
        [JsonProperty(PropertyName = "PeriodChangePrecent")]
        public double? PeriodChangePercent;
        public double? PeriodChangeValue;
    }
}
