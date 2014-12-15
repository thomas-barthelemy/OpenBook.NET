namespace OpenBook
{
    class OpenBookParams
    {

    }

    public enum SortBy
    {
        Copiers,
        Gain,
    }

    public enum RiskLevel
    {
        Low,
        Medium,
        High
    }

    public enum MarketCategory
    {
        Currencies = 1,
        Commodities = 2,
        Indicies = 3,
        Stocks = 4
    }

    public enum PositionType
    {
        Real,
        Demo
    }

    public enum PositionTime
    {
        Current,
        History
    }
}
