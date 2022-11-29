using System.Collections.Generic;

namespace TrainingCenter.Models
{
    public class Instructor
    {
        public int InstructorId { get; set; }
        public string Name { get; set; }
        public float Salary { get; set; }
        public float Bonus { get; set; }
        public string Address { get; set; }
        public float Hour_Rate { get; set; }

        // Navigation Property 
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public List<Course_Instructor> course_Instructors { get; set; } 
    }
}
