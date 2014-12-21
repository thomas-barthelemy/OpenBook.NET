using System.Collections.Generic;

namespace OpenBook.Models.ApiResults.FeaturedSymbols
{
    public class Category
    {
        public string Type { get; set; }
        public List<FeaturedSymbol> Symbols { get; set; }
    }
}
