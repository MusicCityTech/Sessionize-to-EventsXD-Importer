using Newtonsoft.Json;

namespace EventsXdWrapper.Models
{
    public class ConferenceSpeaker
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("bio")]
        public string Bio { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("imageURL")]
        public string ImageUrl { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("facebook")]
        public string Facebook { get; set; }

        [JsonProperty("linkedIn")]
        public string LinkedIn { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("fullName")]
        public string FullName => $"{this.FirstName} {this.LastName}";

        [JsonProperty("speakerImage")]
        public string SpeakerImage { get; set; }

        public ConferenceSpeaker()
        {
            this.SpeakerImage = "/Content/assets/img/defaultspeakerimage.jpg";
        }
    }
}
