using System.Collections.Generic;

namespace OpenBook.Models.ApiResults
{
    public class FeaturedSymbolsResult
    {
        public List<SymbolsData> FeaturedSymbols { get; set; }
        public List<CategoryData> Categories { get; set; }

        public class CategoryData
        {
            public string Type { get; set; }
            public List<SymbolsData> Symbols { get; set; }
        }

        public struct SymbolRatesModel
        {
            public int InstrumentID;
            public double? PeriodChangePrecent;
            public double? PeriodChangeValue;
            public int Precision;
            public double Price;
        }

        public class SymbolsData
        {
            public Symbol Symbol { get; set; }
            public SymbolRatesModel SymbolRatesModel { get; set; }
        }
    }
}