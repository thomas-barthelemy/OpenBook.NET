namespace OpenBook.Models
{
    public abstract class User
    {

        public long CID { get; set; }
        public string Username { get; set; }
        public bool AllowDisplayFullName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string URL { get; set; }

        public Country Country { get; set; }
        public UserAvatars Avatars { get; set; }

        public class DetailedUser : User
        {
            public bool FeedLocked { get; set; }
            public long GCID { get; set; }
            public bool? IsAllowShareFollow { get; set; }
            public bool IsFirstLogin { get; set; }
            public long KAID { get; set; }
            public bool OptIn { get; set; }
            public bool SplitUserStreamAllowed { get; set; }
            public string Stars { get; set; }
            public string Token { get; set; }
            public int TotalCopiers { get; set; }
            public int TotalFollows { get; set; }
            public string UserType { get; set; }
        }
    }
}
