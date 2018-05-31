using SessionizeWrapper.Models;

namespace EventsXdWrapper
{
    public static class MusicCityDataDataImporter
    {
        private static int SessionizeConferenceId => 5391;
        private static int EventsXdConferenceId => 5698;
        public static int SessionTrackId => 10597;
        public static int WorkshopTrackId => 10599;
        private static string BuildingName => "Student Life Center"; //TODO: Ask Gaines

        public static void Import(SessionizeData sessionizeData)
        {
            SessionizeDataImporter.Import(EventsXdConferenceId, SessionizeConferenceId, BuildingName, sessionizeData);
        }
    }
}
