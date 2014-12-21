namespace OpenBook.Models.ApiResults.UserProfileDetails
{
    public class ProfileUser : UserBase
    {
        public bool HasUploadedAvatar { get; set; }
        public string UserType { get; set; }
    }
}
