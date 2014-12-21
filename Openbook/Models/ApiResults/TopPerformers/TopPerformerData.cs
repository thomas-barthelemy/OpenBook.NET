using System.Collections.Generic;

namespace OpenBook.Models.ApiResults.TopPerformers
{
    public class TopPerformerData : LocalizedResultBase
    {
        public int RankingType { get; set; }
        public string Title { get; set; }
        public bool IsDefault { get; set; }
        public List<TopUserData> Users { get; set; }
    }
}
