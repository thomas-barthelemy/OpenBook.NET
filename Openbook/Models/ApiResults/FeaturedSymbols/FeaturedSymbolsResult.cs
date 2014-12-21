using System.Collections.Generic;

namespace OpenBook.Models.ApiResults.FeaturedSymbols
{
    public class FeaturedSymbolsResult
    {
        public List<SymbolsData> FeaturedSymbols { get; set; }
        public List<CategoryData> Categories { get; set; }
    }
}