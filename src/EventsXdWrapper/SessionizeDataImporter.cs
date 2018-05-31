using System;
using System.Collections.Generic;
using System.Linq;
using EventsXdWrapper.Models;
using SessionizeWrapper.Models;

namespace EventsXdWrapper
{
    public static class SessionizeDataImporter
    {
        public static void Import(int eventsXdConferenceId, int sessionizeConferenceId, string buildingName, SessionizeData sessionizeData)
        {
            //ClearCurrentSpeakers(eventsXdConferenceId);
            //ImportSpeakers(eventsXdConferenceId, sessionizeConferenceId, sessionizeData);

            //ClearCurrentSessionTimes(eventsXdConferenceId);
            //ImportSessionTimes(eventsXdConferenceId, sessionizeConferenceId, sessionizeData);

            //ClearCurrentRooms(eventsXdConferenceId);
            //ImportRooms(eventsXdConferenceId, sessionizeConferenceId, buildingName, sessionizeData);

            //ClearCurrentLevels(eventsXdConferenceId);
            //ImportLevels(eventsXdConferenceId, sessionizeConferenceId, sessionizeData);

            //ClearCurrentTags(eventsXdConferenceId);
            //ImportTags(eventsXdConferenceId, sessionizeConferenceId, sessionizeData);

            //ClearCurrentSessionTypes(eventsXdConferenceId);
            //ImportSessionTypes(eventsXdConferenceId, sessionizeConferenceId, sessionizeData);

            //ClearCurrentSession(eventsXdConferenceId);
            ImportSessions(eventsXdConferenceId, sessionizeConferenceId, sessionizeData);
        }

        private static void ClearCurrentSpeakers(int eventsXdConferenceId)
        {
            var currentSpeakersJson = EventsXdService.ConferenceSpeakers.GetAll(eventsXdConferenceId);

            var currentSpeakers = currentSpeakersJson.FromJson<IList<ConferenceSpeaker>>();

            foreach (var speaker in currentSpeakers)
            {
                Console.WriteLine(EventsXdService.ConferenceSpeakers.Delete(eventsXdConferenceId, int.Parse(speaker.Id)));
            }
        }

        private static void ImportSpeakers(int eventsXdConferenceId, int sessionizeConferenceId, SessionizeData sessionizeData)
        {
            //var codeSessions = sessionizeData.Sessions
            //    .Where(x => x.CategoryItems.Contains(sessionizeConferenceId))
            //    .ToList();

            //var codeSpeakers = (
            //    from speaker in sessionizeData.Speakers
            //    let codeSessionsForSpeaker = codeSessions.Any(x => x.Speakers.Contains(speaker.Id))
            //    where codeSessionsForSpeaker
            //    select speaker
            //    ).ToList();

            var speakers = sessionizeData.Speakers.ToList();

            var eventsxdSpeakers = speakers
                .Select(x => new ConferenceSpeaker
                {
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    Bio = x.Bio,
                    Url = x.Links?.FirstOrDefault(y => y.LinkType == "Blog")?.Url
                        ?? x.Links?.FirstOrDefault(y => y.LinkType == "Company_Website")?.Url
                        ?? x.Links?.FirstOrDefault(y => y.LinkType == "Other")?.Url,
                    ImageUrl = x.ProfilePicture,
                    Twitter = x.Links?.FirstOrDefault(y => y.LinkType == "Twitter")?.Url,
                    LinkedIn = x.Links?.FirstOrDefault(y => y.LinkType == "LinkedIn")?.Url,
                    Title = x.TagLine,
                    SpeakerImage = x.ProfilePicture
                })
                .ToList();

            foreach (var speaker in eventsxdSpeakers)
            {
                Console.WriteLine(EventsXdService.ConferenceSpeakers.Add(eventsXdConferenceId, speaker));
            }
        }

        private static void ClearCurrentSessionTimes(int eventsXdConferenceId)
        {
            var currentSessionTimesJson = EventsXdService.SessionTimes.GetAll(eventsXdConferenceId);

            var currentSessionTimes = currentSessionTimesJson.FromJson<IList<Timeslot>>();

            foreach (var timeslot in currentSessionTimes)
            {
                Console.WriteLine(EventsXdService.SessionTimes.Delete(eventsXdConferenceId, int.Parse(timeslot.Id)));
            }
        }

        private static void ImportSessionTimes(int eventsXdConferenceId, int sessionizeConferenceId, SessionizeData sessionizeData)
        {
            var codeSessions = sessionizeData.Sessions
                .Where(x => x.CategoryItems.Contains(sessionizeConferenceId))
                .ToList();

            var timeslots = codeSessions
                .Select(x => new Tuple<string, string>(x.StartsAt, x.EndsAt))
                .Distinct()
                .Select(x => new Timeslot
                {
                    StartTime = DateTime.Parse(x.Item1).AddHours(-4),
                    EndTime = DateTime.Parse(x.Item2).AddHours(-4),
                    Description = DateTime.Parse(x.Item1).ToString("dddd h:mm tt")
                })
                .Select(x => new Timeslot
                {
                    StartTime = x.StartTime,
                    EndTime = x.EndTime,
                    Description = $"{x.Description} {(x.EndTime.Subtract(x.StartTime).Hours > 2 ? "Workshop" : null)}".Trim()
                }).ToList();

            foreach (var timeslot in timeslots)
            {
                Console.WriteLine(EventsXdService.SessionTimes.Add(eventsXdConferenceId, timeslot));
            }
        }

        private static void ClearCurrentRooms(int eventsXdConferenceId)
        {
            var currentRoomsJson = EventsXdService.Rooms.GetAll(eventsXdConferenceId);

            var currentRooms = currentRoomsJson.FromJson<IList<Models.Room>>();

            foreach (var room in currentRooms)
            {
                Console.WriteLine(EventsXdService.Rooms.Delete(eventsXdConferenceId, int.Parse(room.Id)));
            }
        }

        private static void ImportRooms(int eventsXdConferenceId, int sessionizeConferenceId, string buildingName, SessionizeData sessionizeData)
        {
            var roomIds = sessionizeData.Sessions
                .Where(x => x.CategoryItems.Contains(sessionizeConferenceId))
                .Select(x => x.RoomId)
                .Distinct()
                .ToList();

            var rooms = sessionizeData.Rooms
                .Where(x => roomIds.Contains(x.Id))
                .Select(x => new Models.Room
                {
                    Name = x.Name,
                    Building = buildingName
                })
                .ToList();

            foreach (var room in rooms)
            {
                Console.WriteLine(EventsXdService.Rooms.Add(eventsXdConferenceId, room));
            }
        }

        private static void ClearCurrentLevels(int eventsXdConferenceId)
        {
            var currentLevelsJson = EventsXdService.Levels.GetAll(eventsXdConferenceId);

            var currentLevels = currentLevelsJson.FromJson<IList<Level>>();

            foreach (var level in currentLevels)
            {
                Console.WriteLine(EventsXdService.Levels.Delete(eventsXdConferenceId, int.Parse(level.Id)));
            }
        }

        private static void ImportLevels(int eventsXdConferenceId, int sessionizeConferenceId, SessionizeData sessionizeData)
        {
            var allLevels = sessionizeData.Categories
                .Where(x => x.Title == "Level")
                .SelectMany(x => x.Items)
                .ToList();

            var sessions = sessionizeData.Sessions
                .Where(x => x.CategoryItems.Contains(sessionizeConferenceId))
                .ToList();

            var levels = allLevels
                .Where(x => sessions.Any(y => y.CategoryItems.Contains(x.Id)))
                .Select(x => new Level
                {
                    Name = x.Name
                })
                .ToList();

            foreach (var level in levels)
            {
                Console.WriteLine(EventsXdService.Levels.Add(eventsXdConferenceId, level));
            }
        }

        private static void ClearCurrentTags(int eventsXdConferenceId)
        {
            var currentTagsJson = EventsXdService.Tags.GetAll(eventsXdConferenceId);

            var currentTags = currentTagsJson.FromJson<IList<Tag>>();

            foreach (var tag in currentTags)
            {
                Console.WriteLine(EventsXdService.Tags.Delete(eventsXdConferenceId, int.Parse(tag.Id)));
            }
        }

        private static void ImportTags(int eventsXdConferenceId, int sessionizeConferenceId, SessionizeData sessionizeData)
        {
            var allTags = sessionizeData.Categories
                .Where(x => x.Title == "Tags")
                .SelectMany(x => x.Items)
                .ToList();

            var sessions = sessionizeData.Sessions
                //.Where(x => x.CategoryItems.Contains(sessionizeConferenceId))
                .ToList();

            var tags = allTags
                .Where(x => sessions.Any(y => y.CategoryItems.Contains(x.Id)))
                .Select(x => new Tag
                {
                    Name = x.Name
                })
                .Distinct()
                .ToList();

            foreach (var tag in tags)
            {
                Console.WriteLine(EventsXdService.Tags.Add(eventsXdConferenceId, tag));
            }
        }

        private static void ClearCurrentSessionTypes(int eventsXdConferenceId)
        {
            var currentSessionTypesJson = EventsXdService.SessionTypes.GetAll(eventsXdConferenceId);

            var currentSessionTypes = currentSessionTypesJson.FromJson<IList<SessionType>>();

            foreach (var sessionType in currentSessionTypes)
            {
                Console.WriteLine(EventsXdService.SessionTypes.Delete(eventsXdConferenceId, int.Parse(sessionType.Id)));
            }
        }

        private static void ImportSessionTypes(int eventsXdConferenceId, int sessionizeConferenceId, SessionizeData sessionizeData)
        {
            var allSessionTypes = sessionizeData.Categories
                .Where(x => x.Title == "Session format")
                .SelectMany(x => x.Items)
                .ToList();

            var sessions = sessionizeData.Sessions
                .Where(x => x.CategoryItems.Contains(sessionizeConferenceId))
                .ToList();

            var sessionTypes = allSessionTypes
                .Where(x => sessions.Any(y => y.CategoryItems.Contains(x.Id)))
                .Select(x => new SessionType
                {
                    Name = x.Name,
                    ShowOnAgenda = true,
                    HasSurvey = false
                })
                .Distinct()
                .ToList();

            foreach (var sessionType in sessionTypes)
            {
                Console.WriteLine(EventsXdService.SessionTypes.Add(eventsXdConferenceId, sessionType));
            }
        }

        private static void ClearCurrentSession(int eventsXdConferenceId)
        {
            var currentSessionsJson = EventsXdService.Sessions.GetAll(eventsXdConferenceId);

            var currentSessions = currentSessionsJson.FromJson<IList<Models.Session>>();

            foreach (var session in currentSessions)
            {
                Console.WriteLine(EventsXdService.Sessions.Delete(eventsXdConferenceId, int.Parse(session.Id)));
            }
        }

        private static void ImportSessions(int eventsXdConferenceId, int sessionizeConferenceId, SessionizeData sessionizeData)
        {
            var timeslots = EventsXdService.SessionTimes.GetAll(eventsXdConferenceId).FromJson<IList<Timeslot>>().ToList();
            var rooms = EventsXdService.Rooms.GetAll(eventsXdConferenceId).FromJson<IList<Models.Room>>().ToList();
            var levels = EventsXdService.Levels.GetAll(eventsXdConferenceId).FromJson<IList<Level>>().ToList();
            var sessionTypes = EventsXdService.SessionTypes.GetAll(eventsXdConferenceId).FromJson<IList<SessionType>>().ToList();
            var speakers = EventsXdService.ConferenceSpeakers.GetAll(eventsXdConferenceId).FromJson<IList<ConferenceSpeaker>>().ToList();
            var tags = EventsXdService.Tags.GetAll(eventsXdConferenceId).FromJson<IList<Tag>>().ToList();
            var tracks = EventsXdService.Tracks.GetAll(eventsXdConferenceId).FromJson<IList<Tag>>().ToList();
            var workshopTrackId = tracks.FirstOrDefault(x => x.Name == "Workshops")?.Id;
            var audiences = EventsXdService.Audiences.GetAll(eventsXdConferenceId).FromJson<IList<Tag>>().ToList();
            var allAccessAudienceId = audiences.FirstOrDefault(x => x.Name == "All Access")?.Id;

            var sessions = sessionizeData.Sessions
                //.Where(x => x.CategoryItems.Contains(sessionizeConferenceId))
                //.Where(x => x.Id == "21437")
                .ToList();

            var sessionizeSessionTypes = sessionizeData.Categories.Where(x => x.Title == "Session format").SelectMany(x => x.Items).ToList();
            var sessionizeTags = sessionizeData.Categories.Where(x => x.Title == "Tags").SelectMany(x => x.Items).ToList();
            var sessionizeLevels = sessionizeData.Categories.Where(x => x.Title == "Level").SelectMany(x => x.Items).ToList();
            var sessionizeRooms = sessionizeData.Rooms.ToList();
            var sessionizeConferences = sessionizeData.Categories.Where(x => x.Title == "Conference").SelectMany(x => x.Items).ToList();

            var sessionizeSpeakers = (
                from speaker in sessionizeData.Speakers
                let sessionsForSpeaker = sessions.Any(x => x.Speakers.Contains(speaker.Id))
                where sessionsForSpeaker
                select speaker
            ).ToList();

            foreach (var session in sessions)
            {
                var timeslotId = timeslots.FirstOrDefault(x => x.StartTime == DateTime.Parse(session.StartsAt))?.Id;

                var sessionizeLocation = sessionizeRooms.FirstOrDefault(x => x.Id == session.RoomId);
                var locationId = rooms.FirstOrDefault(x => x.Name == sessionizeLocation?.Name)?.Id;

                var sessionizeLevel = sessionizeLevels.FirstOrDefault(x => session.CategoryItems.Contains(x.Id));
                var levelId = levels.FirstOrDefault(x => x.Name == sessionizeLevel?.Name)?.Id;

                var sessionizeSessionType = sessionizeSessionTypes.FirstOrDefault(x => session.CategoryItems.Contains(x.Id));
                var sessionTypeId = sessionTypes.FirstOrDefault(x => x.Name == sessionizeSessionType?.Name)?.Id;

                var sessionizeSpeakersNames = sessionizeSpeakers.Where(x => session.Speakers.Contains(x.Id)).Select(x => x.FullName).ToList();
                var speakerIds = speakers.Where(x => sessionizeSpeakersNames.Contains(x.FullName)).Select(x => x.Id).ToList();

                var sessionizeTagsNames = sessionizeTags.Where(x => session.CategoryItems.Contains(x.Id)).Select(x => x.Name).ToList();
                var tagIds = tags.Where(x => sessionizeTagsNames.Contains(x.Name)).Select(x => x.Id).ToList();

                var conference = sessionizeConferences.FirstOrDefault(x => session.CategoryItems.Contains(x.Id));

                var trackIds = new List<string>
                {
                    tracks.FirstOrDefault(x => x.Name == conference?.Name)?.Id
                };

                var addWorkshopTrack = sessionTypes.Any(x => x.Id == sessionTypeId && x.Name == "Workshops");
                if (addWorkshopTrack)
                {
                    trackIds.Add(workshopTrackId);
                }

                var audienceIds = new List<string>
                {
                    audiences.FirstOrDefault(x=>x.Name == conference?.Name)?.Id,
                    allAccessAudienceId
                };

                var newSession = new Models.Session
                {
                    Name = session.Title,
                    Description = session.Description,
                    TimeslotId = timeslotId,
                    LocationId = locationId,
                    LevelId = levelId,
                    IsSponsorSession = false,
                    SessionTypeId = sessionTypeId,
                    SpeakerIds = speakerIds,
                    TrackIds = trackIds,
                    AudienceIds = audienceIds,
                    TagIds = tagIds
                };

                EventsXdService.Sessions.Add(eventsXdConferenceId, newSession);

                Console.WriteLine($"Imported {newSession.Name}");
            }
        }
    }
}
