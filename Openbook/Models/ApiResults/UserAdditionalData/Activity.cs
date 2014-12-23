namespace OpenBook.Models.ApiResults.UserAdditionalData
{
    public class Activity
    {
        public string GUID { get; set; }
        public bool IsBuy { get; set; }
        public bool IsOrder { get; set; }
        public double OpenRate { get; set; }
        public int OrderID { get; set; }
        public int PositionID { get; set; }
        public string Profit { get; set; }
        public string Risk { get; set; }
        public string TimeStamp { get; set; }
    }
}
