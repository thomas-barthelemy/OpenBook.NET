using System.Collections.Generic;

namespace OpenBook.Models.ApiResults.UserPreviewStats
{
    public class RiskData : LocalizedResultBase
    {
        public List<ValueData> Values { get; set; }
    }
}
