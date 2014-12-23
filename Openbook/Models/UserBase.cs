namespace OpenBook.Models
{
    public abstract class UserBase
    {
        public long CID { get; set; }
        public string Username { get; set; }
        public bool AllowDisplayFullName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string URL { get; set; }
        public Country Country { get; set; }
        public UserAvatars Avatars { get; set; }
    }
}
