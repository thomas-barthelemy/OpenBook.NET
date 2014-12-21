using System.Collections.Generic;

namespace OpenBook.Models.ApiResults.UserPreviewStats
{
    public class PNLData : LocalizedResultBase
    {
        public string StartDate { get; set; }
        public int Interval { get; set; }
        public List<TickData> Ticks { get; set; }
    }
}
