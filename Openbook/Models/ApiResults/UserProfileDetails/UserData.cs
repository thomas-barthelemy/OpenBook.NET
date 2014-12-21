namespace OpenBook.Models.ApiResults.UserProfileDetails
{
    public class UserData : User
    {
        public bool HasUploadedAvatar { get; set; }
        public string UserType { get; set; }
    }
}
