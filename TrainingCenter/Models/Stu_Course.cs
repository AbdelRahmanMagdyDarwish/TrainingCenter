namespace TrainingCenter.Models
{
    public class Stu_Course
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public char Grade { get; set; }

        //Navigation Property
        public Student Student { get; set; }
        public Course Course { get; set;}
    }
}
