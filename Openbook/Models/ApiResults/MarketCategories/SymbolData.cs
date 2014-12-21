namespace OpenBook.Models.ApiResults.MarketCategories
{
    public class SymbolData
    {
        public Symbol Symbol { get; set; }
        public MarketCategoriesSymbolRatesModel SymbolRatesModel { get; set; }
        public double[] SparkChart { get; set; }
    }
}
