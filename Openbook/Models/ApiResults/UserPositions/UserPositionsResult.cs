namespace OpenBook.Models.ApiResults.UserPositions
{
    public class UserPositionsResult
    {
        public bool IsHistory { get; set; }
        public bool IsReal { get; set; }
        public PositionsHolder Positions { get; set; }
    }
}
