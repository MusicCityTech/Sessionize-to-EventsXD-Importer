using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace EventsXdWrapper.Models
{
    public class Session
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("timeSlotID")]
        public string TimeslotId { get; set; }

        [JsonProperty("timeSlot")]
        public string Timeslot { get; set; }

        [JsonProperty("locationID")]
        public string LocationId { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("levelID")]
        public string LevelId { get; set; }

        [JsonProperty("level")]
        public string Level { get; set; }

        [JsonProperty("isSponsorSession")]
        public bool IsSponsorSession { get; set; }

        [JsonProperty("requiresRegistration")]
        public bool RequiresRegistration { get; set; }

        [JsonProperty("registrationStartDate")]
        public DateTime? RegistrationStartDate { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("sessionTypeID")]
        public string SessionTypeId { get; set; }

        [JsonProperty("sessionType")]
        public string SessionType { get; set; }

        [JsonProperty("sessionStatus")]
        public int SessionStatus { get; set; }

        [JsonProperty("showOnEveryOnesAgenda")]
        public bool ShowOnEveryOnesAgenda { get; set; }

        [JsonProperty("isPrivate")]
        public bool IsPrivate { get; set; }

        [JsonProperty("isOfficial")]
        public bool IsOfficial { get; set; }

        [JsonProperty("canInviteOthers")]
        public bool CanInviteOthers { get; set; }

        [JsonProperty("tracks")]
        public string Tracks{ get; set; }

        [JsonProperty("speakerIds")]
        public IList<string> SpeakerIds { get; set; }

        [JsonProperty("trackIds")]
        public IList<string> TrackIds{ get; set; }

        [JsonProperty("audienceIds")]
        public IList<string> AudienceIds { get; set; }

        [JsonProperty("tagIds")]
        public IList<string> TagIds { get; set; }

        [JsonProperty("startTime")]
        public DateTime? StartTime { get; set; }

        [JsonProperty("endTime")]
        public DateTime? EndTime { get; set; }

        public Session()
        {
            this.SessionStatus = 2;
            this.ShowOnEveryOnesAgenda = true;
            this.IsPrivate = false;
            this.IsOfficial = true;
            this.CanInviteOthers = false;
        }
    }
}
