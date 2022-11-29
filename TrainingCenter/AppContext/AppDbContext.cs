using Microsoft.EntityFrameworkCore;
using TrainingCenter.Models;

namespace TrainingCenter.AppContext
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course_Instructor>()
                .HasKey(x=> new {x.CourseId , x.InstructorId});
            modelBuilder.Entity<Stu_Course>()
                .HasKey(x => new { x.StudentId, x.CourseId });
            

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Course_Instructor> course_Instructors { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Stu_Course> Stu_Courses { get; set; }
        public DbSet<Topic> Topics { get; set; }

    }

}
