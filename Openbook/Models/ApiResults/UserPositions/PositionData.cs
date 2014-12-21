namespace OpenBook.Models.ApiResults.UserPositions
{
    public class PositionData : LocalizedResultBase
    {
        public int OrderID { get; set; }
        public string Units { get; set; }
        public bool IsBuy { get; set; }
        public Market Market { get; set; }
        public double? StopLoss { get; set; }
        public double? TakeProfit { get; set; }
        public double Amount { get; set; }
        public double OpenRate { get; set; }
        public double? CloseRate { get; set; }
        public string NetProfit { get; set; }
        public string Gain { get; set; }
        public string CloseDate { get; set; }
        public User.DetailedUser ParentUser { get; set; }
        public string CloseReason { get; set; }
        public string OpenDate { get; set; }
        public long PositionId { get; set; }
        public int Risk { get; set; }
        public bool OverWeekend { get; set; }
        public bool IsSelf { get; set; }
        public double OriginalAmount { get; set; }
        public double OriginalNetProfit { get; set; }
        public string OriginalOpenDate { get; set; }
        public bool IsPending { get; set; }
        public bool IsCancelling { get; set; }
        public bool IsFrozen { get; set; }
    }
}
