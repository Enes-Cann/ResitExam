namespace ResitExam.Dto
{
    public class ResitApplicationRequest
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public bool AppliedToResitExam { get; set; } // Tıklanıp tıklanmadığını temsil eder
    }
}
