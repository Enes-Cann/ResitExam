using System.ComponentModel.DataAnnotations;

namespace ResitExam.MODEL
{
    public class MakeUpExam
    {
        [Key]
        public int ExamID { get; set; }
        public string CourseCode { get; set; }
        public string ExamDetails { get; set; }
        public DateTime ExamTime { get; set; }
        
        public List<Student> Students { get; set; }//deneme

    }
}
