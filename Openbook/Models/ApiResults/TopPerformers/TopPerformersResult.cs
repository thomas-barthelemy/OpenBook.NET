using System.Collections.Generic;

namespace OpenBook.Models.ApiResults.TopPerformers
{
    public class TopPerformersResult : LocalizedResultBase
    {
        public string Title { get; set; }
        public List<TopPerformer> TopPerformers { get; set; }
    }
}
