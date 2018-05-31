using Newtonsoft.Json;

namespace EventsXdWrapper.Models
{
    public class SessionType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("showOnAgenda")]
        public bool ShowOnAgenda { get; set; }

        [JsonProperty("surveyID")]
        public string SurveyId { get; set; }

        [JsonProperty("surveyName")]
        public string SurveyName { get; set; }

        [JsonProperty("hasSurvey")]
        public bool HasSurvey { get; set; }
    }
}
