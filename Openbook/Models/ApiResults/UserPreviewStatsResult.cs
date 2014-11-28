using System.Collections.Generic;
using Newtonsoft.Json;

namespace OpenBook.Models.ApiResults
{
    public class UserPreviewStatsResult
    {
        public RiskData Risk { get; set; }
        public PNLData PNL { get; set; }
        public UserPerformanceData UserPerformance { get; set; }

        public class RiskData : LocalizedResultBase
        {
            public List<ValueData> Values { get; set; }

            public class ValueData : LocalizedResultBase
            {
                public string Name { get; set; }
                public double Value { get; set; }
            }
        }

        public class PNLData : LocalizedResultBase
        {
            public string StartDate { get; set; }
            public int Interval { get; set; }
            public List<TickData> Ticks { get; set; } 

            public struct TickData
            {
                [JsonProperty(PropertyName = "x")]
                public string X;

                [JsonProperty(PropertyName = "y")]
                public double Y;
            }
        }

        public class UserPerformanceData : LocalizedResultBase
        {
            public double Gain { get; set; }
            public double GainPercentage { get; set; }
            public double MaxWeeklyDrawdown { get; set; }
            public double ProfitableWeeks { get; set; }
            public double WinRatio { get; set; }
        }
    }
}
