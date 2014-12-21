using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenBook;
using OpenBook.Models.ApiResults.Ranking;
using OpenBook.Models.ApiResults.UserPositions;

namespace OpenBookNetUnitTest
{
    /// <summary>
    ///     Users related unit tests
    /// </summary>
    [TestClass]
    public class UsersUnitTests
    {
        private readonly OpenBookClient _client = new OpenBookClient();

        private readonly string[] _sampleUsers =
        {
            "BestTraders", "Dimitrios1",
            "Greenlander88"
        };


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
            var result = _client.GetAdditionalData(_sampleUsers).Result;

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count == 3);

            foreach (var pair in result)
            {
                Assert.IsTrue(_sampleUsers.Contains(pair.Key));
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
        public void GetUserPreviewStats()
        {
            var result = _client.GetPreviewStats(_sampleUsers[0]).Result;

            Assert.IsNotNull(result.UserPerformance);
            Assert.IsNotNull(result.Risk);
            Assert.IsNotNull(result.PNL);
            Assert.IsNotNull(result.Risk.Values);

            foreach (var value in result.Risk.Values)
            {
                Assert.IsNotNull(value);
            }

            Assert.IsNotNull(result.PNL.Ticks);

            foreach (var tick in result.PNL.Ticks)
            {
                Assert.IsNotNull(tick);
            }
        }

        [TestMethod]
        public void GetUserProfileDetails()
        {
            var result = _client.GetProfileDetails(_sampleUsers[0]).Result;

            Assert.IsNotNull(result);
            Assert.IsNotNull(result.User);
        }

        [TestMethod]
        public void GetUserPositions_Default()
        {
            var result = _client.GetUserPositions(_sampleUsers[0]).Result;
            CheckPositionResult(result);
        }

        [TestMethod]
        public void GetUserPositions_Demo()
        {
            var result =
                _client.GetUserPositions(_sampleUsers[0],
                    PositionType.Demo).Result;
            CheckPositionResult(result);
        }

        [TestMethod]
        public void GetUserPositions_History()
        {
            var result =
                _client.GetUserPositions(_sampleUsers[0],
                    positionTime: PositionTime.History).Result;
            CheckPositionResult(result);
        }

        private static void CheckRankingResult(RankingResult result)
        {
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count != 0);
            Assert.IsNotNull(result.Users);
            Assert.IsTrue(result.Users.Count > 0);

            foreach (var user in result.Users)
            {
                Assert.IsNotNull(user);
            }
        }

        private static void CheckPositionResult(UserPositionsResult result)
        {
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.Positions);
            Assert.IsNotNull(result.Positions.Positions);
            foreach (var position in result.Positions.Positions)
            {
                Assert.IsNotNull(position);
                Assert.IsNotNull(position.ParentUser);
            }
        }
    }
}