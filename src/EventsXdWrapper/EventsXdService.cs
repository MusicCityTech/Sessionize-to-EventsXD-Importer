using RestSharp;

namespace EventsXdWrapper
{
    public static class EventsXdService
    {
        internal static readonly RestClient Client;

        static EventsXdService()
        {
            Client = new RestClient(Settings.ApiUri);
        }

        public static string ListConferences()
        {
            var request = Client.CreateEventsXdRequest("api/ConferenceInfo", Method.GET);

            return Client.Execute(request)?.Content;
        }

        public static class Conferences
        {
            public static string Get(int conferenceId)
            {
                var request = Client.CreateEventsXdRequest($"api/ConferenceInfo/{conferenceId}", Method.GET);

                return Client.Execute(request)?.Content;
            }

            public static string GetAll()
            {
                var request = Client.CreateEventsXdRequest("api/ConferenceInfo", Method.GET);

                return Client.Execute(request)?.Content;
            }

            //TODO: Finish this
            //public static string Add(Models.ConferenceSpeaker speaker)
            //{
            //    var request = Client.CreateEventsXdRequest($"api/ConferenceInfo/{conferenceId}/speaker/undefined", Method.POST);

            //    request.AddJsonBody(speaker);

            //    return Client.Execute(request)?.Content;
            //}

            //TODO: Finish this
            public static string Update(int conferenceId, Models.ConferenceSpeaker speaker)
            {
                var request = Client.CreateEventsXdRequest($"api/ConferenceInfo/{conferenceId}/speaker/{speaker.Id}", Method.PUT);

                request.AddJsonBody(speaker);

                return Client.Execute(request)?.Content;
            }

            //TODO: Finish this
            public static string Delete(int conferenceId)
            {
                var request = Client.CreateEventsXdRequest($"api/ConferenceInfo/{conferenceId}", Method.DELETE);

                return Client.Execute(request)?.Content;
            }
        }

        public static class ConferenceSpeakers
        {
            public static string Get(int conferenceId, int speakerId)
            {
                var request = Client.CreateEventsXdRequest($"api/ConferenceInfo/{conferenceId}/speaker/{speakerId}/detail", Method.GET);

                return Client.Execute(request)?.Content;
            }

            public static string GetAll(int conferenceId)
            {
                var request = Client.CreateEventsXdRequest($"api/ConferenceInfo/{conferenceId}/speaker", Method.GET);

                return Client.Execute(request)?.Content;
            }

            public static string Add(int conferenceId, Models.ConferenceSpeaker speaker)
            {
                var request = Client.CreateEventsXdRequest($"api/ConferenceInfo/{conferenceId}/speaker/undefined", Method.POST);

                request.AddJsonBody(speaker);

                return Client.Execute(request)?.Content;
            }

            public static string Update(int conferenceId, Models.ConferenceSpeaker speaker)
            {
                var request = Client.CreateEventsXdRequest($"api/ConferenceInfo/{conferenceId}/speaker/{speaker.Id}", Method.PUT);

                request.AddJsonBody(speaker);

                return Client.Execute(request)?.Content;
            }

            public static string Delete(int conferenceId, int speakerId)
            {
                var request = Client.CreateEventsXdRequest($"api/ConferenceInfo/{conferenceId}/speaker/{speakerId}", Method.DELETE);

                return Client.Execute(request)?.Content;
            }
        }

        public static class SessionTimes
        {
            public static string Get(int conferenceId, int sessionTimeId)
            {
                var request = Client.CreateEventsXdRequest($"api/ConferenceInfo/{conferenceId}/timeslot/{sessionTimeId}/detail", Method.GET);

                return Client.Execute(request)?.Content;
            }

            public static string GetAll(int conferenceId)
            {
                var request = Client.CreateEventsXdRequest($"api/ConferenceInfo/{conferenceId}/timeslot", Method.GET);

                return Client.Execute(request)?.Content;
            }

            public static string Add(int conferenceId, Models.Timeslot timeslot)
            {
                var request = Client.CreateEventsXdRequest($"api/ConferenceInfo/{conferenceId}/timeslot", Method.POST);

                request.AddJsonBody(timeslot);

                return Client.Execute(request)?.Content;
            }

            public static string Update(int conferenceId, Models.Timeslot timeslot)
            {
                var request = Client.CreateEventsXdRequest($"api/ConferenceInfo/{conferenceId}/timeslot/{timeslot.Id}", Method.PUT);

                request.AddJsonBody(timeslot);

                return Client.Execute(request)?.Content;
            }

            public static string Delete(int conferenceId, int sessionTimeId)
            {
                var request = Client.CreateEventsXdRequest($"api/ConferenceInfo/{conferenceId}/timeslot/{sessionTimeId}", Method.DELETE);

                return Client.Execute(request)?.Content;
            }
        }

        public static class Rooms
        {
            public static string Get(int conferenceId, int roomId)
            {
                var request = Client.CreateEventsXdRequest($"api/ConferenceInfo/{conferenceId}/location/{roomId}/detail", Method.GET);

                return Client.Execute(request)?.Content;
            }

            public static string GetAll(int conferenceId)
            {
                var request = Client.CreateEventsXdRequest($"api/ConferenceInfo/{conferenceId}/location", Method.GET);

                return Client.Execute(request)?.Content;
            }

            public static string Add(int conferenceId, Models.Room room)
            {
                var request = Client.CreateEventsXdRequest($"api/ConferenceInfo/{conferenceId}/location", Method.POST);

                request.AddJsonBody(room);

                return Client.Execute(request)?.Content;
            }

            public static string Update(int conferenceId, Models.Room room)
            {
                var request = Client.CreateEventsXdRequest($"api/ConferenceInfo/{conferenceId}/location/{room.Id}", Method.PUT);

                request.AddJsonBody(room);

                return Client.Execute(request)?.Content;
            }

            public static string Delete(int conferenceId, int roomId)
            {
                var request = Client.CreateEventsXdRequest($"api/ConferenceInfo/{conferenceId}/location/{roomId}", Method.DELETE);

                return Client.Execute(request)?.Content;
            }
        }

        public static class Levels
        {
            public static string Get(int conferenceId, int levelId)
            {
                var request = Client.CreateEventsXdRequest($"api/ConferenceInfo/{conferenceId}/level/{levelId}/detail", Method.GET);

                return Client.Execute(request)?.Content;
            }

            public static string GetAll(int conferenceId)
            {
                var request = Client.CreateEventsXdRequest($"api/ConferenceInfo/{conferenceId}/level", Method.GET);

                return Client.Execute(request)?.Content;
            }

            public static string Add(int conferenceId, Models.Level level)
            {
                var request = Client.CreateEventsXdRequest($"api/ConferenceInfo/{conferenceId}/level", Method.POST);

                request.AddJsonBody(level);

                return Client.Execute(request)?.Content;
            }

            public static string Update(int conferenceId, Models.Level level)
            {
                var request = Client.CreateEventsXdRequest($"api/ConferenceInfo/{conferenceId}/level/{level.Id}", Method.PUT);

                request.AddJsonBody(level);

                return Client.Execute(request)?.Content;
            }

            public static string Delete(int conferenceId, int levelId)
            {
                var request = Client.CreateEventsXdRequest($"api/ConferenceInfo/{conferenceId}/level/{levelId}", Method.DELETE);

                return Client.Execute(request)?.Content;
            }
        }

        public static class Tracks
        {
            public static string Get(int conferenceId, int trackId)
            {
                var request = Client.CreateEventsXdRequest($"api/ConferenceInfo/{conferenceId}/track/{trackId}/detail", Method.GET);

                return Client.Execute(request)?.Content;
            }

            public static string GetAll(int conferenceId)
            {
                var request = Client.CreateEventsXdRequest($"api/ConferenceInfo/{conferenceId}/track", Method.GET);

                return Client.Execute(request)?.Content;
            }

            public static string Add(int conferenceId, Models.Track track)
            {
                var request = Client.CreateEventsXdRequest($"api/ConferenceInfo/{conferenceId}/track", Method.POST);

                request.AddJsonBody(track);

                return Client.Execute(request)?.Content;
            }

            public static string Update(int conferenceId, Models.Track track)
            {
                var request = Client.CreateEventsXdRequest($"api/ConferenceInfo/{conferenceId}/track/{track.Id}", Method.PUT);

                request.AddJsonBody(track);

                return Client.Execute(request)?.Content;
            }

            public static string Delete(int conferenceId, int trackId)
            {
                var request = Client.CreateEventsXdRequest($"api/ConferenceInfo/{conferenceId}/track/{trackId}", Method.DELETE);

                return Client.Execute(request)?.Content;
            }
        }

        public static class Tags
        {
            public static string Get(int conferenceId, int tagId)
            {
                var request = Client.CreateEventsXdRequest($"api/ConferenceInfo/{conferenceId}/tag/{tagId}/detail", Method.GET);

                return Client.Execute(request)?.Content;
            }

            public static string GetAll(int conferenceId)
            {
                var request = Client.CreateEventsXdRequest($"api/ConferenceInfo/{conferenceId}/tag", Method.GET);

                return Client.Execute(request)?.Content;
            }

            public static string Add(int conferenceId, Models.Tag tag)
            {
                var request = Client.CreateEventsXdRequest($"api/ConferenceInfo/{conferenceId}/tag", Method.POST);

                request.AddJsonBody(tag);

                return Client.Execute(request)?.Content;
            }

            public static string Update(int conferenceId, Models.Tag tag)
            {
                var request = Client.CreateEventsXdRequest($"api/ConferenceInfo/{conferenceId}/tag/{tag.Id}", Method.PUT);

                request.AddJsonBody(tag);

                return Client.Execute(request)?.Content;
            }

            public static string Delete(int conferenceId, int tagId)
            {
                var request = Client.CreateEventsXdRequest($"api/ConferenceInfo/{conferenceId}/tag/{tagId}", Method.DELETE);

                return Client.Execute(request)?.Content;
            }
        }

        public static class SessionTypes
        {
            public static string Get(int conferenceId, int sessionTypeId)
            {
                var request = Client.CreateEventsXdRequest($"api/ConferenceInfo/{conferenceId}/sessionType/{sessionTypeId}/detail", Method.GET);

                return Client.Execute(request)?.Content;
            }

            public static string GetAll(int conferenceId)
            {
                var request = Client.CreateEventsXdRequest($"api/ConferenceInfo/{conferenceId}/sessionType", Method.GET);

                return Client.Execute(request)?.Content;
            }

            public static string Add(int conferenceId, Models.SessionType sessionType)
            {
                var request = Client.CreateEventsXdRequest($"api/ConferenceInfo/{conferenceId}/sessionType", Method.POST);

                request.AddJsonBody(sessionType);

                return Client.Execute(request)?.Content;
            }

            public static string Update(int conferenceId, Models.SessionType sessionType)
            {
                var request = Client.CreateEventsXdRequest($"api/ConferenceInfo/{conferenceId}/sessionType/{sessionType.Id}", Method.PUT);

                request.AddJsonBody(sessionType);

                return Client.Execute(request)?.Content;
            }

            public static string Delete(int conferenceId, int sessionTypeId)
            {
                var request = Client.CreateEventsXdRequest($"api/ConferenceInfo/{conferenceId}/sessionType/{sessionTypeId}", Method.DELETE);

                return Client.Execute(request)?.Content;
            }
        }

        public static class Sessions
        {
            public static string Get(int conferenceId, int sessionId)
            {
                var request = Client.CreateEventsXdRequest($"api/ConferenceInfo/{conferenceId}/session/{sessionId}/detail", Method.GET);

                return Client.Execute(request)?.Content;
            }

            public static string GetAll(int conferenceId)
            {
                var request = Client.CreateEventsXdRequest($"api/ConferenceInfo/{conferenceId}/session", Method.GET);

                return Client.Execute(request)?.Content;
            }

            public static string Add(int conferenceId, Models.Session session)
            {
                var request = Client.CreateEventsXdRequest($"api/ConferenceInfo/{conferenceId}/session", Method.POST);

                request.AddJsonBody(session);

                return Client.Execute(request)?.Content;
            }

            public static string Update(int conferenceId, Models.Session session)
            {
                var request = Client.CreateEventsXdRequest($"api/ConferenceInfo/{conferenceId}/session/{session.Id}", Method.PUT);

                request.AddJsonBody(session);

                return Client.Execute(request)?.Content;
            }

            public static string Delete(int conferenceId, int sessionId)
            {
                var request = Client.CreateEventsXdRequest($"api/ConferenceInfo/{conferenceId}/session/{sessionId}", Method.DELETE);

                return Client.Execute(request)?.Content;
            }
        }

        public static class Audiences
        {
            //public static string Get(int conferenceId, int audienceId)
            //{
            //    var request = Client.CreateEventsXdRequest($"api/ConferenceInfo/{conferenceId}/audience/{audienceId}/detail", Method.GET);

            //    return Client.Execute(request)?.Content;
            //}

            public static string GetAll(int conferenceId)
            {
                var request = Client.CreateEventsXdRequest($"api/ConferenceInfo/{conferenceId}/audience", Method.GET);

                return Client.Execute(request)?.Content;
            }

            //public static string Add(int conferenceId, Models.Tag tag)
            //{
            //    var request = Client.CreateEventsXdRequest($"api/ConferenceInfo/{conferenceId}/tag", Method.POST);

            //    request.AddJsonBody(tag);

            //    return Client.Execute(request)?.Content;
            //}

            //public static string Update(int conferenceId, Models.Tag tag)
            //{
            //    var request = Client.CreateEventsXdRequest($"api/ConferenceInfo/{conferenceId}/tag/{tag.Id}", Method.PUT);

            //    request.AddJsonBody(tag);

            //    return Client.Execute(request)?.Content;
            //}

            //public static string Delete(int conferenceId, int tagId)
            //{
            //    var request = Client.CreateEventsXdRequest($"api/ConferenceInfo/{conferenceId}/tag/{tagId}", Method.DELETE);

            //    return Client.Execute(request)?.Content;
            //}
        }
    }
}
