using System.Collections.Generic;
using RestSharp;

namespace SessionizeWrapper.Models
{
    public class SessionizeData
    {
        public IList<Session> Sessions { get; set; }
        public IList<Speaker> Speakers { get; set; }
        public IList<Question> Questions { get; set; }
        public IList<Category> Categories { get; set; }
        public IList<Room> Rooms { get; set; }

        public static SessionizeData Retreive()
        {
            var client = new RestClient(SessionizeSettings.ApiUrl);

            var request = new RestRequest("", Method.GET);

            var json = client.Execute(request)?.Content;

            var sessionizeData = json.FromJson<SessionizeData>();

            return SessionizeDataCleanser.Cleanse(sessionizeData);
        }
    }
}
