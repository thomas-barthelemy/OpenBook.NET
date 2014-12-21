using System.Collections.Generic;

namespace OpenBook.Models.ApiResults.MarketCategories
{
    public class MarketCategoriesResult
    {
        public string[] Tag { get; set; }
        public string Type { get; set; }
        public List<SymbolData> Symbols { get; set; }
    }
}