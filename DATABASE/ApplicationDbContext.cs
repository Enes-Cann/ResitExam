using Microsoft.EntityFrameworkCore;
using ResitExam.MODEL;
namespace ResitExam.DATABASE
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        // Tabloları temsil eden DbSet'ler
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<ResitExamObj> ResitExams { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<FacultySecretary> FacultySecretaries { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>().HasMany<Course>(s => s.Courses).WithMany(c => c.Students);
            modelBuilder.Entity<Course>().HasOne<Instructor>(c => c.Instructor).WithMany(i => i.Courses);
            modelBuilder.Entity<Course>().HasMany<Student>(s => s.Students).WithMany(c => c.Courses);
            //modelBuilder.Entity<Student<>().HasMany<ResitExamObj>(s => s.ResitExams).WithOne(r => r.Student);
            
            modelBuilder.Entity<Role>().HasData(
        new Role { Id = 1, Name = "Student" },
        new Role { Id = 2, Name = "Instructors" },
        new Role { Id = 3, Name = "FacultySecretary" }
    );
        }

    }    
}
