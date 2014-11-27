using System.Collections.Generic;

namespace OpenBook.Models.ApiResults
{
    class MarketResult
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
    }
}
