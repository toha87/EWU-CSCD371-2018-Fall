using System;
using System.Collections.Generic;

namespace UniversityCourseWork
{
    public class Schedule : UniversityCourse, IEvent
    {
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