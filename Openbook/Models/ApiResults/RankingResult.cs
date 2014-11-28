using System.Collections.Generic;

namespace OpenBook.Models.ApiResults
{
    public class RankingResult : LocalizedResultBase
    {
        public List<UserData> Users { get; set; }
        public int Count { get; set; }
        public Pagination Pagination { get; set; }

        public class UserData : User
        {
            public double ProfitableWeeks { get; set; }
            public double MaxDrawDown { get; set; }
            public int Copiers { get; set; }
            public double Velocity { get; set; }
            public double Gain { get; set; }
            public int Rank { get; set; }
        }
    }
}
