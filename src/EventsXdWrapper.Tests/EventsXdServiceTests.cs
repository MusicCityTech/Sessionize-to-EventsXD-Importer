using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace EventsXdWrapper.Tests
{
    public class EventsXdServiceTests
    {
        public class Conferences
        {
            [Test]
            public void Get()
            {
                Console.WriteLine(EventsXdService.Conferences.Get(5577).ToFormattedJson());
            }

            [Test]
            public void GetAll()
            {
                Console.WriteLine(EventsXdService.Conferences.GetAll().ToFormattedJson());
            }

            //TODO
            //[Test]
            //public void Add()
            //{
            //    var speaker = new Models.ConferenceSpeaker
            //    {
            //        FirstName = "Brian",
            //        LastName = "Korzynski",
            //        Biography = "The most awesomest",
            //        Url = "http://blog.com",
            //        Title = "Your Boss",
            //        Company = "Some Company",
            //        Twitter = "bkorzynski"
            //    };

            //    Console.WriteLine(EventsXdService.ConferenceSpeakers.Add(5577, speaker));
            //}

            //[Test]
            //public void Update()
            //{
            //    var speaker = new Models.ConferenceSpeaker
            //    {
            //        Id = "100466",
            //        FirstName = "Brian",
            //        LastName = "Korzynski",
            //        Biography = "The most awesomest",
            //        Url = "http://blog.com",
            //        Title = "Your Boss",
            //        Company = "Some Company2",
            //        Twitter = "bkorzynski"
            //    };

            //    Console.WriteLine(EventsXdService.ConferenceSpeakers.Update(5577, speaker));
            //}

            [Test]
            public void Delete()
            {
                Console.WriteLine(EventsXdService.Conferences.Delete(5673).ToFormattedJson());
            }
        }

        public class ConferenceSpeakers
        {
            [Test]
            public void Get()
            {
                Console.WriteLine(EventsXdService.ConferenceSpeakers.Get(5577, 100466).ToFormattedJson());
            }

            [Test]
            public void GetAll()
            {
                Console.WriteLine(EventsXdService.ConferenceSpeakers.GetAll(5577).ToFormattedJson());
            }

            [Test]
            public void Add()
            {
                var speaker = new Models.ConferenceSpeaker
                {
                    FirstName = "Brian",
                    LastName = "Korzynski",
                    Bio = "The most awesomest",
                    Url = "http://blog.com",
                    Title = "Your Boss",
                    Company = "Some Company",
                    Twitter = "bkorzynski"
                };

                Console.WriteLine(EventsXdService.ConferenceSpeakers.Add(5577, speaker));
            }

            [Test]
            public void Update()
            {
                var speaker = new Models.ConferenceSpeaker
                {
                    Id = "100466",
                    FirstName = "Brian",
                    LastName = "Korzynski",
                    Bio = "The most awesomest",
                    Url = "http://blog.com",
                    Title = "Your Boss",
                    Company = "Some Company2",
                    Twitter = "bkorzynski"
                };

                Console.WriteLine(EventsXdService.ConferenceSpeakers.Update(5577, speaker));
            }

            [Test]
            public void Delete()
            {
                Console.WriteLine(EventsXdService.ConferenceSpeakers.Delete(5577, 100467).ToFormattedJson());
            }
        }

        public class SessionTimes
        {
            [Test]
            public void Get()
            {
                Console.WriteLine(EventsXdService.SessionTimes.Get(5577, 78050).ToFormattedJson());
            }

            [Test]
            public void GetAll()
            {
                Console.WriteLine(EventsXdService.SessionTimes.GetAll(5577).ToFormattedJson());
            }

            [Test]
            public void Add()
            {
                var timeslot = new Models.Timeslot
                {
                    StartTime = new DateTime(2018, 5, 21, 4, 0, 0),
                    EndTime = new DateTime(2018, 5, 21, 5, 0, 0),
                    Description = "First Timeslot",
                };

                Console.WriteLine(EventsXdService.SessionTimes.Add(5577, timeslot));
            }

            [Test]
            public void Update()
            {
                var timeslot = new Models.Timeslot
                {
                    StartTime = new DateTime(2018, 5, 21, 4, 30, 0),
                    EndTime = new DateTime(2018, 5, 21, 7, 30, 0),
                    Description = "Second Timeslot2",
                    Id = "78043"
                };

                Console.WriteLine(EventsXdService.SessionTimes.Update(5577, timeslot));
            }

            [Test]
            public void Delete()
            {
                Console.WriteLine(EventsXdService.SessionTimes.Delete(5577, 78034).ToFormattedJson());
                Console.WriteLine(EventsXdService.SessionTimes.Delete(5577, 78035).ToFormattedJson());
                Console.WriteLine(EventsXdService.SessionTimes.Delete(5577, 78036).ToFormattedJson());
                Console.WriteLine(EventsXdService.SessionTimes.Delete(5577, 78038).ToFormattedJson());
                Console.WriteLine(EventsXdService.SessionTimes.Delete(5577, 78043).ToFormattedJson());
                Console.WriteLine(EventsXdService.SessionTimes.Delete(5577, 78028).ToFormattedJson());
                Console.WriteLine(EventsXdService.SessionTimes.Delete(5577, 78032).ToFormattedJson());
            }
        }

        public class Rooms
        {
            [Test]
            public void Get()
            {
                Console.WriteLine(EventsXdService.Rooms.Get(5577, 25192).ToFormattedJson());
            }

            [Test]
            public void GetAll()
            {
                Console.WriteLine(EventsXdService.Rooms.GetAll(5577).ToFormattedJson());
            }

            [Test]
            public void Add()
            {
                var room = new Models.Room
                {
                    Name = "Room 123",
                    Building = "Korzplex",
                };

                Console.WriteLine(EventsXdService.Rooms.Add(5577, room));
            }

            [Test]
            public void Update()
            {
                var room = new Models.Room
                {
                    Name = "Room 123",
                    Building = "Korzplex",
                    Id = "25190"
                };

                Console.WriteLine(EventsXdService.Rooms.Update(5577, room));
            }

            [Test]
            public void Delete()
            {
                Console.WriteLine(EventsXdService.Rooms.Delete(5577, 25190).ToFormattedJson());
            }
        }

        public class Levels
        {
            [Test]
            public void Get()
            {
                Console.WriteLine(EventsXdService.Levels.Get(5577, 2784).ToFormattedJson());
            }

            [Test]
            public void GetAll()
            {
                Console.WriteLine(EventsXdService.Levels.GetAll(5577).ToFormattedJson());
            }

            [Test]
            public void Add()
            {
                var level = new Models.Level
                {
                    Name = "Intro",
                    Description = "Introductory Topic",
                };

                Console.WriteLine(EventsXdService.Levels.Add(5577, level));
            }

            [Test]
            public void Update()
            {
                var level = new Models.Level
                {
                    Name = "Introduction",
                    Description = "Introductory Topic",
                    Id  = "2784"
                };

                Console.WriteLine(EventsXdService.Levels.Update(5577, level));
            }

            [Test]
            public void Delete()
            {
                Console.WriteLine(EventsXdService.Levels.Delete(5577, 2784).ToFormattedJson());
            }
        }

        public class Tracks
        {
            [Test]
            public void Get()
            {
                Console.WriteLine(EventsXdService.Tracks.Get(5577, 10553).ToFormattedJson());
            }

            [Test]
            public void GetAll()
            {
                Console.WriteLine(EventsXdService.Tracks.GetAll(5706).ToFormattedJson());
            }

            [Test]
            public void Add()
            {
                var track = new Models.Track
                {
                    Name = ".Net",
                    Description = "All things .Net",
                    Color = "Blue"
                };

                Console.WriteLine(EventsXdService.Tracks.Add(5577, track));
            }

            [Test]
            public void Update()
            {
                var track = new Models.Track
                {
                    Name = ".Net",
                    Description = "All things .Net",
                    Color = "Green",
                    Id = "10550"
                };

                Console.WriteLine(EventsXdService.Tracks.Update(5577, track));
            }

            [Test]
            public void Delete()
            {
                Console.WriteLine(EventsXdService.Tracks.Delete(5577, 10551).ToFormattedJson());
            }
        }

        public class Tags
        {
            [Test]
            public void Get()
            {
                Console.WriteLine(EventsXdService.Tags.Get(5577, 19770).ToFormattedJson());
            }

            [Test]
            public void GetAll()
            {
                Console.WriteLine(EventsXdService.Tags.GetAll(5577).ToFormattedJson());
            }

            [Test]
            public void Add()
            {
                var tag = new Models.Tag
                {
                    Name = ".Net",
                };

                Console.WriteLine(EventsXdService.Tags.Add(5577, tag));
            }

            [Test]
            public void Update()
            {
                var tag = new Models.Tag
                {
                    Name = "C#",
                    Id = "19869"
                };

                Console.WriteLine(EventsXdService.Tags.Update(5577, tag));
            }

            [Test]
            public void Delete()
            {
                Console.WriteLine(EventsXdService.Tags.Delete(5577, 19770).ToFormattedJson());
                Console.WriteLine(EventsXdService.Tags.Delete(5577, 19867).ToFormattedJson());
            }
        }

        public class SessionTypes
        {
            [Test]
            public void Get()
            {
                Console.WriteLine(EventsXdService.SessionTypes.Get(5577, 14906).ToFormattedJson());
            }

            [Test]
            public void GetAll()
            {
                Console.WriteLine(EventsXdService.SessionTypes.GetAll(5577).ToFormattedJson());
            }

            [Test]
            public void Add()
            {
                var sessionType = new Models.SessionType
                {
                    Name = "Talk",
                    HasSurvey = false,
                    ShowOnAgenda = false
                };

                Console.WriteLine(EventsXdService.SessionTypes.Add(5577, sessionType));
            }

            [Test]
            public void Update()
            {
                var sessionType = new Models.SessionType
                {
                    Name = "Talk",
                    HasSurvey = true,
                    ShowOnAgenda = false,
                    Id = "14912"
                };

                Console.WriteLine(EventsXdService.SessionTypes.Update(5577, sessionType));
            }

            [Test]
            public void Delete()
            {
                Console.WriteLine(EventsXdService.SessionTypes.Delete(5577, 14906).ToFormattedJson());
                Console.WriteLine(EventsXdService.SessionTypes.Delete(5577, 14907).ToFormattedJson());
                Console.WriteLine(EventsXdService.SessionTypes.Delete(5577, 14912).ToFormattedJson());
            }
        }

        public class Sessions
        {
            [Test]
            public void Get()
            {
                Console.WriteLine(EventsXdService.Sessions.Get(5577, 121472).ToFormattedJson());
            }

            [Test]
            public void GetAll()
            {
                Console.WriteLine(EventsXdService.Sessions.GetAll(5577).ToFormattedJson());
            }

            [Test]
            public void Add()
            {
                var session = new Models.Session
                {
                    Name = "Introduction to Amazon AWS",
                    Description = "Talk description",
                    TimeslotId = "78056",
                    LocationId = "25194",
                    //LevelId = 
                    IsSponsorSession = false,
                    SessionTypeId = "14915",
                    SpeakerIds = new List<string> { "101508" },
                    TrackIds = new List<string> { "10554" },
                    TagIds = new List<string> { "19869" },
                };

                Console.WriteLine(EventsXdService.Sessions.Add(5577, session));
            }

            [Test]
            public void Update()
            {
                var session = new Models.Session
                {
                    Name = "[VENDOR] Introduction to Amazon AWS",
                    Description = "Talk description",
                    TimeslotId = "78056",
                    LocationId = "25194",
                    //LevelId = 
                    IsSponsorSession = true,
                    SessionTypeId = "14915",
                    SpeakerIds = new List<string> { "101508" },
                    TrackIds = new List<string> { "10554" },
                    TagIds = new List<string> { "19869" },
                    Id = "121473"
                };

                Console.WriteLine(EventsXdService.Sessions.Update(5577, session));
            }

            [Test]
            public void Delete()
            {
                Console.WriteLine(EventsXdService.Sessions.Delete(5577, 121472).ToFormattedJson());
            }
        }

        public class Audiences
        {
            //[Test]
            //public void Get()
            //{
            //    Console.WriteLine(EventsXdService.Tracks.Get(5577, 10553).ToFormattedJson());
            //}

            [Test]
            public void GetAll()
            {
                Console.WriteLine(EventsXdService.Audiences.GetAll(5706).ToFormattedJson());
            }

            //[Test]
            //public void Add()
            //{
            //    var track = new Models.Track
            //    {
            //        Name = ".Net",
            //        Description = "All things .Net",
            //        Color = "Blue"
            //    };

            //    Console.WriteLine(EventsXdService.Tracks.Add(5577, track));
            //}

            //[Test]
            //public void Update()
            //{
            //    var track = new Models.Track
            //    {
            //        Name = ".Net",
            //        Description = "All things .Net",
            //        Color = "Green",
            //        Id = "10550"
            //    };

            //    Console.WriteLine(EventsXdService.Tracks.Update(5577, track));
            //}

            //[Test]
            //public void Delete()
            //{
            //    Console.WriteLine(EventsXdService.Tracks.Delete(5577, 10551).ToFormattedJson());
            //}
        }
    }
}
