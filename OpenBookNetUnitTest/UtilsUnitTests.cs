using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenBook;

namespace OpenBookNetUnitTest
{
    [TestClass]
    public class UtilsUnitTests
    {
        private readonly OpenBookClient _client = new OpenBookClient();

        [TestMethod]
        public void GetQueryUri()
        {
            const string testUri = "http://test.uri.com/api";
            const string expectedResult =
                testUri + "?key1=value1&key2=value2&key3=value3";
            var query = new Dictionary<string, string>
            {
                {"key1", "value1"},
                {"key2", "value2"},
                {"key3", "value3"},
            };

            var uri = _client.GetQueryUri(testUri, query);

            Assert.IsNotNull(uri);
            Assert.AreEqual(expectedResult, uri.ToString());
        }
    }
}
