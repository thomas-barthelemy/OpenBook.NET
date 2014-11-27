using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenBook;
using OpenBook.Models.ApiResults;

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
        public void GetUserAdditionalData()
        {
            var users = new [] {"BestTraders", "Dimitrios1", "Greenlander88"};
            var result = _client.GetAdditionalData(users).Result;

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count == 3);

            foreach (var pair in result)
            {
                Assert.IsTrue(users.Contains(pair.Key));
                var userData = pair.Value;
                Assert.IsNotNull(userData.LastActivity);
                Assert.IsNotNull(userData.PNL);
                Assert.IsNotNull(userData.LastActivity.Activity);
                Assert.IsNotNull(userData.LastActivity.Market);
                Assert.IsNotNull(userData.LastActivity.Owner);
            }
        }

        [TestMethod]
        public void GetTopPerformers()
        {
            var result = _client.GetTopPerformers().Result;

            Assert.IsNotNull(result);
            Assert.IsNotNull(result.TopPerformers);
            Assert.IsTrue(result.TopPerformers.Count > 0);

            foreach (var topPerformerData in result.TopPerformers)
            {
                Assert.IsNotNull(topPerformerData);
                Assert.IsNotNull(topPerformerData.Users);

                foreach (var topUserData in topPerformerData.Users)
                {
                    Assert.IsNotNull(topUserData);
                    Assert.IsNotNull(topUserData.User);
                    Assert.IsNotNull(topUserData.Ranking);
                }
            }
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
