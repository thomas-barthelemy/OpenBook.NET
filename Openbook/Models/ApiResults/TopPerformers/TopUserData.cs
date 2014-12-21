namespace OpenBook.Models.ApiResults.TopPerformers
{
    public class TopUserData : LocalizedResultBase
    {
        public TopUser User { get; set; }
        public Ranking Ranking { get; set; }
        public int Followers { get; set; }
    }
}
