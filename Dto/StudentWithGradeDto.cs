namespace ResitExam.DtoObj
{
    public class StudentWithGradeDto
    {
        public int Id { get; set; }              // Student ID
        public string Name { get; set; }         // Öğrenci adı
        public string Email { get; set; }        // Mail (Student.cs'de var)
        public string LetterGrade { get; set; }  // Şimdilik boş dön, UI için hazır tut
    }
}
