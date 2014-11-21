namespace OpenBook
{
    public class User
    {
        public int ProfitableWeeks { get; set; }
        public double MaxDrawDown { get; set; }
        public long CID { get; set; }
        public string Username { get; set; }
        public bool AllowDisplayFullName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string URL { get; set; }
        public int Copiers { get; set; }
        public double Velocity { get; set; }
        public double Gain { get; set; }
        public int Rank { get; set; }

        public Country Country { get; set; }
        public UserAvatars Avatars { get; set; }
    }
}
