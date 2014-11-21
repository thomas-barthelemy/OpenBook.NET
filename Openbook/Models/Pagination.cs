using System.Collections.Generic;

namespace OpenBook.Models
{
    public class Pagination
    {
        public int CurrentPage { get; set; }
        public int TotalResults { get; set; }
        public int CurrentPageResults { get; set; }
        public string Tag { get; set; }
        public int MaxItemsPerPage { get; set; }
        public string CultureCode { get; set; }
        public Dictionary<string,string> Resources { get; set; }
    }
}
