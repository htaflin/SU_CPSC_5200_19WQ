using System;
using System.Collections.Generic;
using System.Linq;
using restapi.Models;

namespace restapi
{
    public static class Database
    {
        private static readonly IDictionary<string, Timecard> Timecards = 
            new Dictionary<string, Timecard>();
        
        public static IEnumerable<Timecard> All
        {
            get => Timecards.Values.ToList();
        }

        public static Timecard Find(string id)
        {
            Timecard timecard = null;

            if (Timecards.TryGetValue(id, out timecard) == true) 
            {
                return timecard;
            }
            else
            {
                return null;
            }
        }

        public static void Add(Timecard timecard)
        {
            Timecards.Add(timecard.Identity.Value, timecard);
        }
        public static void Remove(Timecard timecard)
        {   
            Timecards.Remove(timecard.Identity.Value); 
        }

      
        public static void Replace (string id, int lineId, TimecardLine newTimecardLine)
        {

            Timecard ourTimecard = Database.Find(id);

            TimecardLine ourTimecardLine = ourTimecard.Lines[lineId]; 

            TimesheetsController a; 

            a.Replace()


            // if (newTimecardLine.Hours > 0)


            // Timecards.Add(timecard.Identity.Value, timecard);
        }

    }
}