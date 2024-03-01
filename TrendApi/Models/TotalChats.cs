namespace TrendApi.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class TotalChats
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("request", NullValueHandling = NullValueHandling.Ignore)]
        public Request Request { get; set; }

        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public long Total { get; set; }

        [JsonProperty("records", NullValueHandling = NullValueHandling.Ignore   )]
        public Dictionary<string, TotalRecord> TotalRecords { get; set; }



    }

    public class TotalRecord
    {
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public long Total { get; set; }
        public Guid ID { get; set; } = Guid.NewGuid();
    }

  
}
