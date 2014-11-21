using System.Collections.Generic;

namespace OpenBook.Models
{
    public class RankingResult
    {
        public List<User> Users { get; set; }
        public int Count { get; set; }
        public Pagination Pagination { get; set; }
        public Dictionary<string, string> Resources { get; set; }
        public string CultureCode { get; set; }
    }
}
