using System.Collections.Generic;

namespace OpenBook.Models.ApiResults
{
    public class TopPerformersResult : LocalizedResultBase
    {
        public string Title { get; set; }
        public List<TopPerformerData> TopPerformers { get; set; }

        public class TopPerformerData : LocalizedResultBase
        {
            public int RankingType { get; set; }
            public string Title { get; set; }
            public bool IsDefault { get; set; }
            public List<TopUserData> Users { get; set; }

            public class TopUserData : LocalizedResultBase
            {
                public User User { get; set; }
                public RankingData Ranking { get; set; }
                public int Followers { get; set; }

                public struct RankingData
                {
                    public int Rank;
                    public double Gain;
                }
            }
        }
    }
}
