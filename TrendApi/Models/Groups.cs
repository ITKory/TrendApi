using Newtonsoft.Json;

namespace TrendApi.Models
{
    public class Groups
    {
        [JsonProperty("values")]
        public List<long> Values { get; set; }
    }
}
