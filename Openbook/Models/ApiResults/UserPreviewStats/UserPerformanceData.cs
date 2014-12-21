namespace OpenBook.Models.ApiResults.UserPreviewStats
{
    public class UserPerformanceData : LocalizedResultBase
    {
        public double Gain { get; set; }
        public double GainPercentage { get; set; }
        public double MaxWeeklyDrawdown { get; set; }
        public double ProfitableWeeks { get; set; }
        public double WinRatio { get; set; }
    }
}
