namespace OpenBook.Models.ApiResults.Ranking
{
    public class UserData : User
    {
        public double ProfitableWeeks { get; set; }
        public double MaxDrawDown { get; set; }
        public int Copiers { get; set; }
        public double Velocity { get; set; }
        public double Gain { get; set; }
        public int Rank { get; set; }
    }
}
