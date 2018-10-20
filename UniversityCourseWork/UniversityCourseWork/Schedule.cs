using System;

namespace UniversityCourseWork
{
    internal class Schedule: UniversityCourse
    {
        public string CourseSchedule { get; set; }

        public Schedule(int CourseId, int CourseNumber, string CourseName,  string CourseStartDate) 
            : base(CourseId, CourseNumber, CourseName)
        {

            CourseSchedule = CourseStartDate;
        }


        public override string GetSummaryInformation()
        {
            string res = $"Course ID: {CourseId}" + $" Course Number: {CourseNumber}" + $" Name: {CourseName} " + $" Date: {CourseSchedule}";
            return res;
        }
    }
}