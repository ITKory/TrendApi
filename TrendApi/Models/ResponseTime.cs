namespace TrendApi.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class ResponseTime
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("request")]
        public Request Request { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("records")]
        public Dictionary<string, ResponseRecord> Records { get; set; }
    }

    public   class ResponseRecord
    {
        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("response_time")]
        public double ResponseTime { get; set; }
    }
 
}
