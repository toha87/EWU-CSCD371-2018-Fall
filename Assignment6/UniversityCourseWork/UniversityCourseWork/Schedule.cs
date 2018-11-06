using System;
using System.Collections.Generic;

namespace UniversityCourseWork
{ 

    public class Schedule : UniversityCourse, IEvent
    {

        [Flags, Serializable]
        public enum WeekDays
        {
            Sunday = 1,
            Monday = 2,
            Tuesday = 4,
            Wednesday = 8,
            Thursday = 16,
            Friday = 32,
            Saturday = 64,
        }

        public enum Quarters
        {
            Spring = 1,
            Summer = 2,
            Fall = 4,
            Winter = 8
        }

        public readonly struct Time
        {
            public readonly int Hour;
            public readonly int Minute;
            public readonly int Second;
        };

        struct Schedules
        {
            public string DayOfWeek { get; set; }
            public string Quarter { get; set; }
            public DateTime StartTime { get; set; }
            public TimeSpan Duration { get; set; }
        };



        public string CourseSchedule { get; set; }

        public Schedule(int CourseId, int CourseNumber, string CourseName,  string CourseStartDate) 
            : base(CourseId, CourseNumber, CourseName)
        {

            CourseSchedule = CourseStartDate;
        }

        public Schedule()
        {
        }

        public override string GetSummaryInformation()
        {
            string res = $"Course ID: {CourseId}" + $" Course Number: {CourseNumber}" + $" Name: {CourseName} " + $" Date: {CourseSchedule}";
            return res;
        }

        public new string TimeNow()
        {
            return DateTime.Now.ToString();
        }
    }
}