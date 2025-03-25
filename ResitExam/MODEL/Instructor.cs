using System.ComponentModel.DataAnnotations;

namespace ResitExam.MODEL
{
    public class Instructor
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        List<Course> Courses { get; set; }
    }
}