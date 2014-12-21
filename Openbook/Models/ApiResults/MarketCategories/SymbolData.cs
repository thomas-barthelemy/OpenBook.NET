namespace OpenBook.Models.ApiResults.MarketCategories
{
    public class SymbolData
    {
        public Symbol Symbol { get; set; }
        public SymbolRatesModelData SymbolRatesModel { get; set; }
        public double[] SparkChart { get; set; }
    }
}
