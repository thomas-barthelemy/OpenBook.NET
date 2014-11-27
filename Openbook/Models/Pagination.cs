using OpenBook.Models.ApiResults;

namespace OpenBook.Models
{
    public class Pagination : LocalizedResultBase
    {
        public int CurrentPage { get; set; }
        public int TotalResults { get; set; }
        public int CurrentPageResults { get; set; }
        public string Tag { get; set; }
        public int MaxItemsPerPage { get; set; }
    }
}
