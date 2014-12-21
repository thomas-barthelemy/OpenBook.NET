namespace OpenBook.Models.ApiResults.TopPerformers
{
    public class TopUserData : LocalizedResultBase
    {
        public UserData User { get; set; }
        public RankingData Ranking { get; set; }
        public int Followers { get; set; }
    }
}
