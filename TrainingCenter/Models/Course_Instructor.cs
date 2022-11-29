namespace TrainingCenter.Models
{
    public class Course_Instructor
    {
        public int CourseId { get; set; }
        public int InstructorId { get; set; }
        public string Evaluation { get; set;}

        public Course Course { get; set;}
        public Instructor Instructor { get; set;}
    }
}
