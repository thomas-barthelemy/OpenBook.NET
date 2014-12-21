namespace OpenBook.Models.ApiResults.TopPerformers
{
    public class TopUser : UserBase
    {
        public bool HasUploadedAvatar { get; set; }
        public string UserType { get; set; }
    }
}
