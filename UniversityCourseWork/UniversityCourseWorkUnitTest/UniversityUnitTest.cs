using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace UniversityCourseWork
{
    [TestClass]
    public class UniversityUnitTest
    {
        [TestMethod]
        public void Create_UniversityCourse_Class()
        {

            UniversityCourse course = new UniversityCourse(145, 371, ".NET Programming");
            UniversityCourse.COUNT++;
            Assert.IsInstanceOfType(course, typeof(UniversityCourse));
        }

        [TestMethod]
        public void Create_ListOf_UniversityCourses()
        {
            UniversityCourse FirstCourse = new UniversityCourse(129, 302, "Computing Ethics");
            UniversityCourse.COUNT++;
            UniversityCourse SecondCourse = new UniversityCourse(145, 371, ".NET Programming");
            UniversityCourse.COUNT++;

            Course.AddCourse(FirstCourse);
            Course.AddCourse(SecondCourse);

            int res = Course.CoursesList.Count();

            Assert.AreEqual(2, res);
        }

        [TestMethod]
        public void GetSummaryInformation()
        {
            Schedule schedule = new Schedule(125, 320, "Algorithms", "10.17.2018");
            UniversityCourse.COUNT++;
            string res = schedule.GetSummaryInformation();

            string str = "Course ID: 0" + " Course Number: 320" + " Name: Algorithms " + " Date: 10.17.2018";
            Assert.AreEqual(str, res);
        }

        private UniversityCourse Course { get; set; }

        [TestInitialize]
        public void Setup()
        {
            Course = new UniversityCourse(125, 320, "Algorithms");
            UniversityCourse.COUNT++;
        }

        [TestMethod]
        public void UniversityCourse_ChangeCourseName_Success()
        {
            Course.CourseName = "Network Programming";
            Assert.AreEqual("Network Programming", Course.CourseName);

            Course.CourseName = "Data Structures";
            Assert.AreEqual("Data Structures", Course.CourseName);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void UniversityCourse_AssignNull_Throws()
        {
            Course = new UniversityCourse(126, 110, null);
            UniversityCourse.COUNT++;
        }

        [TestMethod]
        public void TestScheduleClass()
        {
            Schedule schedule = new Schedule(125, 320, "Algorithms", "10.17.2018");
            UniversityCourse.COUNT++;

        }

        [TestMethod]
        public void Add_With_CourseSchedule()
        {
            UniversityCourse.CourseList.Clear();

            UniversityCourse course = new Schedule(123, 110, "PC Basics", "10.20.18");
            UniversityCourse.COUNT++;

            int count = UniversityCourse.Display(course);

            Assert.AreEqual(1, count);
        }


    }
}
