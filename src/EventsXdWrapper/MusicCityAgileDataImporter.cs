using SessionizeWrapper.Models;

namespace EventsXdWrapper
{
    public static class MusicCityAgileDataImporter
    {
        private static int SessionizeConferenceId => 5390;
        private static int EventsXdConferenceId => 5697;
        public static int SessionTrackId => 10596;
        public static int WorkshopTrackId => 10599;
        private static string BuildingName => "Alumni Hall"; //TODO: Ask Gaines

        public static void Import(SessionizeData sessionizeData)
        {
            SessionizeDataImporter.Import(EventsXdConferenceId, SessionizeConferenceId, BuildingName, sessionizeData);
        }
    }
}
