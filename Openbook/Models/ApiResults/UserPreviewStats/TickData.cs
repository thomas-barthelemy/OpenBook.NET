using Newtonsoft.Json;

namespace OpenBook.Models.ApiResults.UserPreviewStats
{
    public struct TickData
    {
        [JsonProperty(PropertyName = "x")]
        public string X;

        [JsonProperty(PropertyName = "y")]
        public double Y;
    }
}
