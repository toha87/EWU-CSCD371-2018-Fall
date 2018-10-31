using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityCourseWork
{
    public class MainProgramClass
    {
        public static List<Schedule> CourseList = new List<Schedule>();

        static IConsole console = new RealConsole();
        private static readonly IEvent events = new Schedule();

        public static IConsole MyConsole { get; set; }

        public static void Main(string[] args)
        {

            int menuUserChoose;

            do
            {
                console.WriteLine("Welcome to University Course Scheduler!");
                console.WriteLine("Please choose from following menu: ");
                console.WriteLine("   1. Add a New Course with Schedule");
                console.WriteLine("   2. Display all Courses");
                console.WriteLine("   3. Exit");
                menuUserChoose = Convert.ToInt32(console.ReadLine());

                if (menuUserChoose == 1)
                {
                    object NewCourseResult = NewCourse();

                    Schedule actualyType = (Schedule)NewCourseResult;

                    CourseList.Add(actualyType);
                }
                else if (menuUserChoose == 2)
                {
                    PrintList(CourseList);
                }


            } while (menuUserChoose != 3);

            Environment.Exit(1);
                        
        }


        public static void PrintList(List<Schedule> CourseList)
        {
            foreach (Schedule course in CourseList)
            {
                console.WriteLine("Course ID: " + course.CourseId + "| Course Name: " + course.CourseName + "| Course Number: " + course.CourseNumber + "| Course Schedule: " + course.CourseSchedule);
            }
        }

        public static Object NewCourse()
        {

            console.WriteLine("Please enter course name: ");
            string course = console.ReadLine();
            console.WriteLine("Please enter class number: ");
            string course_number_string = console.ReadLine();

            int course_number = Convert.ToInt32(course_number_string);


            console.WriteLine("Please enter date when class starts: (mm/dd/yy)");
            string time = console.ReadLine();

            Random r = new Random();
            int courseId = r.Next(1, 1000);

            Schedule schedule = new Schedule(courseId, course_number, course, time);

            return schedule;
        }

    }


}
