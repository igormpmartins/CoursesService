using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace CoursesServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [DataContract]
    public class Course
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
    }

    [ServiceContract(SessionMode = SessionMode.Required)]
    public interface ICourses
    {
        [OperationContract(IsInitiating = true)]
        void AddToCourses(Course course);

        [OperationContract(IsTerminating = true)]
        List<Course> ListCourses();
    }

}
