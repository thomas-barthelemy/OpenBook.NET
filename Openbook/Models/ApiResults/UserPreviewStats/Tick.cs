using Newtonsoft.Json;

namespace OpenBook.Models.ApiResults.UserPreviewStats
{
    public struct Tick
    {
        [JsonProperty(PropertyName = "x")]
        public string X;

        [JsonProperty(PropertyName = "y")]
        public double Y;
    }
}
