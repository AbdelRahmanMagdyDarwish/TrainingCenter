using System.Collections.Generic;

namespace TrainingCenter.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Duration { get; set; }

        //Navigation Property
        public int TopicId { get; set; }
        public Topic Topic { get; set; }
        public List<Stu_Course> CourseStudent { get; set; }
        public List<Course_Instructor> course_Instructors { get; set; }
    }
}
