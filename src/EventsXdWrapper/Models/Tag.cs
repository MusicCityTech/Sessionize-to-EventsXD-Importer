using Newtonsoft.Json;

namespace EventsXdWrapper.Models
{
    public class Tag
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
