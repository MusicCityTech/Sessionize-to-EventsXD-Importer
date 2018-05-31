using System;
using Newtonsoft.Json;

namespace EventsXdWrapper.Models
{
    public class Timeslot
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("startTime")]
        public DateTime StartTime { get; set; }

        [JsonProperty("endTime")]
        public DateTime EndTime { get; set; }

        [JsonProperty("readableStartTime")]
        public string ReadableStart { get; set; }

        [JsonProperty("readableEndTime")]
        public string ReadableEnd { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
