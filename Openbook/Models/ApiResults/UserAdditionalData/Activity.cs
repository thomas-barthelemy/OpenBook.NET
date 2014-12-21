namespace OpenBook.Models.ApiResults.UserAdditionalData
{
    public struct Activity
    {
        public string GUID;
        public bool IsBuy;
        public bool IsOrder;
        public double OpenRate;
        public int OrderID;
        public int PositionID;
        public string Profit;
        public string Risk;
        public string TimeStamp;
    }
}
