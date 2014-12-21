namespace OpenBook.Models.ApiResults.UserPreviewStats
{
    public class UserPreviewStatsResult
    {
        public RiskData Risk { get; set; }
        public PNLData PNL { get; set; }
        public UserPerformanceData UserPerformance { get; set; }
    }
}
