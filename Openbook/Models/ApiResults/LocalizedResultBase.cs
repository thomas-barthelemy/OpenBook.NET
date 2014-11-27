using System.Collections.Generic;

namespace OpenBook.Models.ApiResults
{
    public abstract class LocalizedResultBase
    {
        public Dictionary<string, string> Resources { get; set; }
        public string CultureCode { get; set; }
    }
}
