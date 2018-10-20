using System;
using System.Collections.Generic;

namespace UniversityCourseWork
{
    internal class UniversityCourse
    {
        public static int COUNT;

        private readonly int _CourceId;
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
            this._CourceId = CourseId;
            this.CourseNumber = CourseNumber;
            this.CourseName = CourseName ?? throw new ArgumentNullException();
        }

        public void Deconstruct(out int courseId, out int courseNumber, out string courseName)
        {
            courseId = CourseId;
            courseNumber = CourseNumber;
            courseName = CourseName;
        }

        public static List<UniversityCourse> CourseList = new List<UniversityCourse>();

        public List<UniversityCourse> CoursesList
        {
            get { return CourseList; }
        }

        public void AddCourse(UniversityCourse course)
        {
            CourseList.Add(course);
        }
        public int CourseCount(List<UniversityCourse> CourseList)
        {
            return CourseList.Count;
        }

        public virtual string GetSummaryInformation()
        {
            return "No Information to Display";
        }

        public static int Display(object @object)
        {
            switch (@object)
            {
                case Schedule course:
                    CourseList.Add(course);
                    break;
                case UniversityCourse course:
                    CourseList.Add(course);
                    break;
                case null:
                    throw new ArgumentNullException(nameof(@object));
                default:
                    throw new ArgumentException("Unknown object type", nameof(@object));
            }

            return CourseList.Count;
        }

    }
}