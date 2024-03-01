namespace TrendApi.Models
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    public partial class Duration
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("request")]
        public Request Request { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("records")]
        public Dictionary<string, DurationRecord> Records { get; set; }
    }

    public   class DurationRecord
    {
        [JsonProperty("agents_chatting_duration")]
        public long AgentsChattingDuration { get; set; }

        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("duration")]
        public long Duration { get; set; }
    }

  

 

  

}
