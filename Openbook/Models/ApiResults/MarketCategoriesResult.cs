using System.Collections.Generic;

namespace OpenBook.Models.ApiResults
{
    public class MarketCategoriesResult
    {
        public string[] Tag { get; set; }
        public string Type { get; set; }
        public List<SymbolData> Symbols { get; set; }

        public class SymbolData
        {
            public Symbol Symbol { get; set; }
            public SymbolRatesModelData SymbolRatesModel { get; set; }
            public double[] SparkChart { get; set; }

            public class SymbolRatesModelData
            {
                public double SentimentPercent { get; set; }
                public string SentimentType { get; set; }
                public RatesData Rates { get; set; }
                public int InstrumentID { get; set; }
                public double? PeriodChangePrecent { get; set; }
                public double? PeriodChangeValue { get; set; }

                public struct RatesData
                {
                    public double Ask;
                    public double Bid;
                    public int InstrumentID;
                    public double? PeriodChangePrecent;
                    public double? PeriodChangeValue;
                    public double Precision;
                }
            }
        }
    }
}