namespace TrendApi.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Rating
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("request")]
        public Request Request { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("records")]
        public Dictionary<string, RatingRecord> Records { get; set; }
    }

    public   class RatingRecord
    {
        [JsonProperty("bad")]
        public long Bad { get; set; }

        [JsonProperty("chats")]
        public long Chats { get; set; }

        [JsonProperty("good")]
        public long Good { get; set; }
    }

 

 

 
}
