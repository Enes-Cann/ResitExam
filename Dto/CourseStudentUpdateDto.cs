using ResitExam.AltSınıflar;

namespace ResitExam.DtoObj
{
    public class CourseStudentUpdateDto
    {
        public int CourseId { get; set; }
        public int StudentId { get; set; }
       public Grade LetterGrade { get; set; }

    }
}
