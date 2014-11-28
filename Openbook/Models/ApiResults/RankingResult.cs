using System.Collections.Generic;

namespace OpenBook.Models.ApiResults
{
    public class RankingResult : LocalizedResultBase
    {
        public List<User> Users { get; set; }
        public int Count { get; set; }
        public Pagination Pagination { get; set; }
    }
}
