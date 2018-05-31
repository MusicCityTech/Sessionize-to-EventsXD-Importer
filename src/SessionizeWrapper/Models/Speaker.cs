using System.Collections.Generic;

namespace SessionizeWrapper.Models
{
    public class Speaker
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Bio { get; set; }
        public string TagLine { get; set; }
        public string ProfilePicture { get; set; }
        public bool IsTopSpeaker { get; set; }
        public IList<Link> Links { get; set; }
        public IList<int> Sessions { get; set; }
        public string FullName { get; set; }
    }
}
