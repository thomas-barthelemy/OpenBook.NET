namespace OpenBook.Models
{
    public class DetailedUser : UserBase
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
