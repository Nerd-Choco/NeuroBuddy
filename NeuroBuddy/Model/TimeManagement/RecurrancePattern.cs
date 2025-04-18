using Microsoft.VisualBasic;
using NeuroBuddy.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroBuddy.Model.TimeManagement
{
    public class RecurrencePattern
    {
        public OccurrenceRate Rate { set; get; }
        public int Interval { set; get; }
        public DateTime? EndTime;
        public List<DayOfWeek>? DaysOfTheWeek { set; get; }
        public int? Occurrences { set; get; }

        private int OccurrencesGenerated = 0;

        
        public RecurrencePattern()
        {

        }
        public RecurrencePattern(OccurrenceRate rate, int interval)
        {
            Rate = rate;
            Interval = interval;
        }
        public RecurrencePattern(OccurrenceRate rate, int interval, DateTime? endTime)
        {
            Rate = rate;
            Interval = interval;
            EndTime = endTime;
        }
        
        public DateTime? GetNextOccurrence(DateTime StartTime)
        {
            var nextDate = StartTime;

            if (Occurrences.HasValue && OccurrencesGenerated > Occurrences.Value || EndTime.HasValue&& nextDate>EndTime.Value)
                return null; 

            switch(Rate)
            {
                case OccurrenceRate.Momently:
                    nextDate = nextDate.AddMinutes(Interval);
                    break;
                case OccurrenceRate.Hourly:
                    nextDate = nextDate.AddHours(Interval);
                    break;
                case OccurrenceRate.Daily:
                    nextDate = nextDate.AddDays(Interval);
                    break;
                case OccurrenceRate.Weekly:
                    for(int i=1; i<= 7*Interval; i++)
                    {
                        if (nextDate < DateTime.MaxValue.AddDays(-1))
                        {
                            nextDate = nextDate.AddDays(1);
                            if (DaysOfTheWeek != null && DaysOfTheWeek.Contains(nextDate.DayOfWeek))
                                break;
                        }
                        else
                        {
                            return null;
                        };
                       
                    }
                    break;
                case OccurrenceRate.Fortnightly:
                    nextDate = nextDate.AddDays(14);
                    break;
                case OccurrenceRate.Monthly:
                    nextDate = nextDate.AddMonths(Interval);
                    break; 
            }
            OccurrencesGenerated++;

            return nextDate; 

        }
        
        public List<DateTime> GetAllOccurrences(DateTime startTime, DateTime EndTime)
        {
            List<DateTime> AllOccurrences = new List<DateTime>();
            DateTime? next = startTime;
            while (next.HasValue && next<= EndTime)
            {
                AllOccurrences.Add(next.Value);
                next = GetNextOccurrence(next.Value);
            }
            return AllOccurrences;
        }

    }
}
