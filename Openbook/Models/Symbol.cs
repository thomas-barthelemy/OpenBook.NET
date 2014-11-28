using System.Collections.Generic;

namespace OpenBook.Models
{
    public class Symbol
    {
        public string CategoryName { get; set; }
        public string DisplayName { get; set; }
        public Dictionary<string,string> Images { get; set; }
        public int InstrumentID { get; set; }
        public InvestmentCounterData InvestmentCounter { get; set; }
        public bool IsTradable { get; set; }
        public string MarketName { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public string TypeName { get; set; }

        public struct InvestmentCounterData
        {
            public int Investors;
            public long UpdatedAt;
        }
    }
}
