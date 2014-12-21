using System.Collections.Generic;

namespace OpenBook.Models.ApiResults.FeaturedSymbols
{
    public class CategoryData
    {
        public string Type { get; set; }
        public List<SymbolsData> Symbols { get; set; }
    }
}
