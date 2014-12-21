using System.Collections.Generic;

namespace OpenBook.Models.ApiResults.UserPreviewStats
{
    public class PNL : LocalizedResultBase
    {
        public string StartDate { get; set; }
        public int Interval { get; set; }
        public List<Tick> Ticks { get; set; }
    }
}
