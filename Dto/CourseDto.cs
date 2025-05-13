namespace ResitExam.DtoObj
{
    public class CourseDto
    {
        public int Id { get; set; }
        public string CourseCode { get; set; }
        public string Name { get; set; }
        public string Grade { get; set; }
        public bool HasResitExamButton { get; set; }
    }
}
