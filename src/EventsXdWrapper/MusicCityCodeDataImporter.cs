using SessionizeWrapper.Models;

namespace EventsXdWrapper
{
    public static class MusicCityCodeDataImporter
    {
        private static int SessionizeConferenceId => 5389;
        private static int EventsXdConferenceId => 5706;
        public static int SessionTrackId => 10595;
        public static int WorkshopTrackId => 10599;
        private static string BuildingName => "Sarratt Student Center"; //TODO: Ask Gaines

        public static void Import(SessionizeData sessionizeData)
        {
            SessionizeDataImporter.Import(EventsXdConferenceId, SessionizeConferenceId, BuildingName, sessionizeData);
        }
    }
}
