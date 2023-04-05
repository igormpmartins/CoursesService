using CourseConsoleClient.CoursesServiceReference;
using System;
using System.Threading;

namespace CourseConsoleClient
{
    internal class Program
    {
        static void Main(string[] args)
        {


            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter course Id and Name");

                //you need to instantiate one client per session
                var client = new CoursesClient("NetTcpBinding_ICourses");

                var course = new Course
                {
                    Id = int.Parse(Console.ReadLine()),
                    Name = Console.ReadLine(),
                };

                client.AddToCourses(course);
                Thread.Sleep(2000);
                GetCourses(client);
            }

            Console.Read();
        }

        private static void GetCourses(CoursesClient client)
        {
            Console.WriteLine("Listing courses...\n");
            var courses = client.ListCourses();
            foreach (var course in courses)
                Console.WriteLine($"Id: {course.Id}, Name: {course.Name}");
        }
    }
}
