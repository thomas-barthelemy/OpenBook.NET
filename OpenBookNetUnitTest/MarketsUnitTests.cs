using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenBook;
using OpenBook.Models.ApiResults.MarketCategories;

namespace OpenBookNetUnitTest
{
    /// <summary>
    /// Markets related unit tests
    /// </summary>
    [TestClass]
    public class MarketsUnitTests
    {
        private readonly OpenBookClient _client = new OpenBookClient();

        [TestMethod]
        public void GetFeaturedSymbols()
        {
            var result = _client.GetFeaturedSymbols().Result;

            Assert.IsNotNull(result);
            Assert.IsNotNull(result.Categories);
            Assert.IsNotNull(result.FeaturedSymbols);

            foreach (var category in result.Categories)
            {
                Assert.IsNotNull(category);
                Assert.IsNotNull(category.Symbols);
                foreach (var symbol in category.Symbols)
                {
                    Assert.IsNotNull(symbol.Symbol);
                    Assert.IsNotNull(symbol.SymbolRatesModel);
                    Assert.IsInstanceOfType(symbol.Symbol.Type, typeof(MarketCategory));
                }
            }

            foreach (var featuredSymbol in result.FeaturedSymbols)
            {
                Assert.IsNotNull(featuredSymbol);
                Assert.IsNotNull(featuredSymbol.Symbol);
                Assert.IsNotNull(featuredSymbol.SymbolRatesModel);
            }
        }

        [TestMethod]
        public void GetTopStocks()
        {
            var result = _client.GetFeaturedSymbols(MarketCategory.Stocks).Result;
            CheckCategorizedFeaturedSymbol(result);
        }

        [TestMethod]
        public void GetTopCurrencies()
        {
            var result = _client.GetFeaturedSymbols(MarketCategory.Currencies).Result;
            CheckCategorizedFeaturedSymbol(result);
        }

        [TestMethod]
        public void GetTopCommodities()
        {
            var result = _client.GetFeaturedSymbols(MarketCategory.Commodities).Result;
            CheckCategorizedFeaturedSymbol(result);
        }

        private void CheckCategorizedFeaturedSymbol(MarketCategoriesResult result)
        {
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.Symbols);

            foreach (var symbol in result.Symbols)
            {
                Assert.IsNotNull(symbol);
                Assert.IsNotNull(symbol.Symbol);
                Assert.IsNotNull(symbol.SymbolRatesModel);
                Assert.IsNotNull(symbol.SymbolRatesModel.Rates);
            }
        }
    }
}
