using Newtonsoft.Json;

namespace TrendApi.Models
{
    public partial class Tags
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("request")]
        public Request Request { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("records")]
        public Dictionary<string, Dictionary<string,int>> Records { get; set; }

    }
 
}
