using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenBook;
using OpenBook.Models;

namespace OpenBookNetUnitTest
{
    /// <summary>
    /// Users related unit tests
    /// </summary>
    [TestClass]
    public class UsersUnitTests
    {
        private readonly OpenBookClient _client = new OpenBookClient();

        [TestMethod]
        public void GetTopUserByCopiers()
        {
            var result = _client.GetRankingAsync(SortBy.Copiers, RiskLevel.Low).Result;

            CheckRankingResult(result);
        }

        [TestMethod]
        public void GetTopUserByGains()
        {
            var result = _client.GetRankingAsync(SortBy.Gain, RiskLevel.Low).Result;
            CheckRankingResult(result);
        }

        [TestMethod]
        public void GetUserFeed()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void GetUserStats()
        {
            throw new NotImplementedException();
        }

// ReSharper disable once UnusedParameter.Local
// Reason: Factorization method
        private static void CheckRankingResult(RankingResult result)
        {
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count != 0);
            Assert.IsNotNull(result.Users);
            Assert.IsTrue(result.Users.Count > 0);
        }
    }
}
