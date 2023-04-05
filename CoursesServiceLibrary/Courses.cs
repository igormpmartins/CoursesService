using System.Collections.Generic;
using System.ServiceModel;

namespace CoursesServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class Courses : ICourses
    {
        private List<Course> courses = new List<Course>();

        public void AddToCourses(Course course)
            => courses.Add(course);

        public List<Course> ListCourses() => courses;

    }
}
