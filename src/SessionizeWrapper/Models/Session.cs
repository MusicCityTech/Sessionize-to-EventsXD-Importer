using System.Collections.Generic;

namespace SessionizeWrapper.Models
{
    public class Session
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string StartsAt { get; set; }
        public string EndsAt { get; set; }
        public bool IsServiceSession { get; set; }
        public bool IsPlenumSession { get; set; }
        public IList<string> Speakers{ get; set; }
        public IList<int> CategoryItems { get; set; }
        public IList<string> QuestionAnswers { get; set; }
        public int RoomId { get; set; }
    }
}
