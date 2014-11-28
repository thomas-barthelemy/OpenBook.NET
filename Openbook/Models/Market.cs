namespace OpenBook.Models
{
    public class Market
    {
        public string CssName { get; set; }
        public bool IsStock { get; set; }
        public string Name { get; set; }
        public Symbol Symbol { get; set; }
        public string Type { get; set; }
        public string URL { get; set; }
    }
}