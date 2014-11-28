namespace OpenBook.Models.ApiResults
{
    public class UserProfileDetailsResult : LocalizedResultBase
    {
        public UserData User { get; set; }
        public int Copiers { get; set; }
        public int Followers { get; set; }
        public bool IsCurrentUserCopy { get; set; }
        public bool IsCurrentUserFollow { get; set; }
        public bool IsVerified { get; set; }
        public int MirrorID { get; set; }
        public string AboutMe { get; set; }
        public bool? IsPaused { get; set; }

        public class UserData : User
        {
            public bool HasUploadedAvatar { get; set; }
            public string UserType { get; set; }
        }
    }
}