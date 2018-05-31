using System.Linq;
using SessionizeWrapper.Models;

namespace SessionizeWrapper
{
    public class SessionizeDataCleanser
    {
        public static SessionizeData Cleanse(SessionizeData sessionizeData)
        {
            sessionizeData = CleanseLevels(sessionizeData);
            sessionizeData = CleanseSessionFormats(sessionizeData);
            sessionizeData = CleanseRooms(sessionizeData);

            return sessionizeData;
        }

        private static SessionizeData CleanseLevels(SessionizeData sessionizeData)
        {
            var levels = sessionizeData.Categories.Where(x => x.Title == "Level").SelectMany(x => x.Items).ToList();

            var introLevel = levels.FirstOrDefault(x => x.Name == "Introductory and overview");

            if (introLevel != null)
            {
                introLevel.Name = "Introductory/Overview";
            }

            return sessionizeData;
        }

        private static SessionizeData CleanseSessionFormats(SessionizeData sessionizeData)
        {
            var levels = sessionizeData.Categories.Where(x => x.Title == "Session format").SelectMany(x => x.Items).ToList();

            var session = levels.FirstOrDefault(x => x.Name == "Session");
            if (session != null) session.Name = "Conference Sessions";

            var workshops = levels.FirstOrDefault(x => x.Name == "Workshop");
            if (workshops != null) workshops.Name = "Workshops";

            return sessionizeData;
        }

        private static SessionizeData CleanseRooms(SessionizeData sessionizeData)
        {
            var rooms = sessionizeData.Rooms.ToList();

            var cinema = rooms.FirstOrDefault(x => x.Name == "Cinema");
            if (cinema != null) cinema.Name = "Sarratt 197 (Cinema)";

            var s216 = rooms.FirstOrDefault(x => x.Name == "S 216/220");
            if (s216 != null) s216.Name = "Sarratt 216/220";

            var s325 = rooms.FirstOrDefault(x => x.Name == "S 325/327");
            if (s325 != null) s325.Name = "Sarratt 325/327";

            var s361 = rooms.FirstOrDefault(x => x.Name == "S 361");
            if (s361 != null) s361.Name = "Sarratt 361";

            var s363 = rooms.FirstOrDefault(x => x.Name == "S 363");
            if (s363 != null) s363.Name = "Sarratt 363";

            var r308 = rooms.FirstOrDefault(x => x.Name == "R 308");
            if (r308 != null) r308.Name = "Rand 308";

            var a100 = rooms.FirstOrDefault(x => x.Name == "A 100");
            if (a100 != null) a100.Name = "Alumni 100 (Lounge)";

            var a201 = rooms.FirstOrDefault(x => x.Name == "A 201");
            if (a201 != null) a201.Name = "Alumni 201 (Classroom)";

            var a202 = rooms.FirstOrDefault(x => x.Name == "A 202");
            if (a202 != null) a202.Name = "Alumni 202 (Memorial Hall)";

            var a204 = rooms.FirstOrDefault(x => x.Name == "A 204/206");
            if (a204 != null) a204.Name = "Alumni 204/206 (Reading Room)";

            var slc008 = rooms.FirstOrDefault(x => x.Name == "SLC 008");
            if (slc008 != null) slc008.Name = "SLC 008";

            var slc010 = rooms.FirstOrDefault(x => x.Name == "SLC 010A");
            if (slc010 != null) slc010.Name = "SLC 010";

            var slc132A = rooms.FirstOrDefault(x => x.Name == "SLC 132 A");
            if (slc132A != null) slc132A.Name = "SLC 132 A";

            var slc132B = rooms.FirstOrDefault(x => x.Name == "SLC 132 B");
            if (slc132B != null) slc132B.Name = "SLC 132 B";

            var slc132C = rooms.FirstOrDefault(x => x.Name == "SLC 132 C");
            if (slc132C != null) slc132C.Name = "SLC 132 C";

            return sessionizeData;
        }
    }
}
