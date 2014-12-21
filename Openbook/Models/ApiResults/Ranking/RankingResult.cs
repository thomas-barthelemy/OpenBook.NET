using System.Collections.Generic;

namespace OpenBook.Models.ApiResults.Ranking
{
    public class RankingResult : LocalizedResultBase
    {
        public List<RankingUserBase> Users { get; set; }
        public int Count { get; set; }
        public Pagination Pagination { get; set; }
    }
}
