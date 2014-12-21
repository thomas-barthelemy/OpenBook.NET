using System.Collections.Generic;

namespace OpenBook.Models.ApiResults.FeaturedSymbols
{
    public class FeaturedSymbolsResult
    {
        public List<FeaturedSymbol> FeaturedSymbols { get; set; }
        public List<Category> Categories { get; set; }
    }
}