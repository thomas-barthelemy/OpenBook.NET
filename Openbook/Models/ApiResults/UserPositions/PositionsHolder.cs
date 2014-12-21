using System.Collections.Generic;

namespace OpenBook.Models.ApiResults.UserPositions
{
    public class PositionsHolder : LocalizedResultBase
    {
        public List<Position> Positions { get; set; }
    }
}
