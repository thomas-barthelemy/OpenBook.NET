using Newtonsoft.Json;

namespace OpenBook.Models.ApiResults.UserPreviewStats
{
    public class Tick
    {
        [JsonProperty(PropertyName = "x")]
        public string X { get; set; }

        [JsonProperty(PropertyName = "y")]
        public double Y { get; set; }
    }
}
