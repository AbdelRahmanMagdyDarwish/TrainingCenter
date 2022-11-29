using Microsoft.Extensions.Primitives;
using System.Collections.Generic;

namespace TrainingCenter.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FName { get; set;}
        public string LName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        //Navigation Property
        public int StudentSupervisor { get; set; }
        public Student Supervisor { get; set; }
        public List<Stu_Course> StudentCourse { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }




    }
}
