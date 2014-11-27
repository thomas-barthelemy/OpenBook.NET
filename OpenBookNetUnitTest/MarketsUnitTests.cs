using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenBook;

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
            throw new NotImplementedException();
        }

        [TestMethod]
        public void GetTopIndices()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void GetTopCurrencies()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void GetTopCommodities()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void GetCurrencyFeed()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void GetCommodityFeed()
        {
            throw new NotImplementedException();
        }
    }
}
