﻿using Newtonsoft.Json;

namespace EventsXdWrapper.Models
{
    public class Level
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
