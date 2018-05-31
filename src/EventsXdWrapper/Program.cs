using System;
using System.Collections.Generic;
using System.Linq;
using EventsXdWrapper.Models;
using SessionizeWrapper.Models;

namespace EventsXdWrapper
{
    class Program
    {
        static void Main(string[] args)
        {
            var sessionizeData = SessionizeData.Retreive();

            MusicCityCodeDataImporter.Import(sessionizeData);
            //MusicCityAgileDataImporter.Import(sessionizeData);
            //MusicCityDataDataImporter.Import(sessionizeData);

            ////Order
            ////      Conference
            ////      Speakers
            ////      SessionTimes
            ////      Rooms
            ////      Tracks (shouldn't be needed since we have difference conferences)
            ////      Levels
            ////      Tags
            ////      SessionTypes
            ////  Sessions



            ////Times are in UTC

            ////Sessions
            ////SessionType
            ////Surveys


            ////Add resources to a session???
            ////Levels???
            ////Audiences???
            ////Resources???
            ////Floor Plans???

            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
