using ResitExam.AltSınıflar;
using ResitExam.MODEL;

namespace ResitExam.MODEL
{
    public class CourseStudent
    {
        public int CourseId { get; set; }
        public Course Course { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }

        public Grade? LetterGrade { get; set; } // enum değilse → string olarak tanımla
    }
}
