namespace ResitExam.MODEL
{
    public class Announcement
    {
        public int Id                { get; set; }
        public string Title          { get; set; }
        public string Content        { get; set; }
        public DateTime CreatedAt    { get; set; } = DateTime.Now;

        public int CourseId          { get; set; }
        public Course Course         { get; set; }

        public int ResitExamObjId { get; set; }
        public ResitExamObj ResitExamObj { get; set; }
    }
}
