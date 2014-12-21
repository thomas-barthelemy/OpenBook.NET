using System.Collections.Generic;

namespace OpenBook.Models.ApiResults.TopPerformers
{
    public class TopPerformersResult : LocalizedResultBase
    {
        public string Title { get; set; }
        public List<TopPerformerData> TopPerformers { get; set; }
    }
}
