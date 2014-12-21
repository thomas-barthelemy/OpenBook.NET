using System.Collections.Generic;

namespace OpenBook.Models.ApiResults.UserPositions
{
    public class PositionsHolder : LocalizedResultBase
    {
        public List<PositionData> Positions { get; set; }
    }
}
