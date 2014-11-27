using System.Collections.Generic;
using Newtonsoft.Json;

namespace OpenBook.Models.ApiResults
{
    public class FeaturedSymbolsResult
    {
        public List<SymbolsData> FeaturedSymbols { get; set; }
        public List<CategoryData> Categories { get; set; }

        public class SymbolsData
        {
            public Symbol Symbol { get; set; }
            public SymbolRatesModel SymbolRatesModel { get; set; }
        }

        public class CategoryData
        {
            public string Type { get; set; }
            public List<SymbolsData> Symbols { get; set; }
        }

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
}
