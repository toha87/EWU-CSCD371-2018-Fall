using System;
using System.Collections.Generic;

namespace UniversityCourseWork
{
    public class UniversityCourse : IEvent
    {
        public static int COUNT;

        public int CourseId { get; }
        
        public int CourseNumber { get; set; }

        private string _CourseName;
        public string CourseName
        {
            get
            {
                return _CourseName;
            }
            set
            {
                _CourseName = value;
            }
        }

        public UniversityCourse(int CourseId, int CourseNumber, string CourseName)
        {
            this.CourseId = CourseId;
            this.CourseNumber = CourseNumber;
            this.CourseName = CourseName ?? throw new ArgumentNullException();
        }

        public UniversityCourse()
        {
        }

        public void Deconstruct(out int courseId, out int courseNumber, out string courseName)
        {
            courseId = CourseId;
            courseNumber = CourseNumber;
            courseName = CourseName;
        }


        public virtual string GetSummaryInformation()
        {
            return "No Information to Display";
        }

        public string TimeNow()
        {
            return DateTime.Now.ToString();
        }

    }
}