using Newtonsoft.Json;

namespace TrendApi.Models
{
    public class Request
    {
        [JsonProperty("distribution")]
        public string Distribution { get; set; }

        [JsonProperty("filters")]
        public Filters Filters { get; set; }
    }
}
