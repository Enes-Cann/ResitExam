namespace ResitExam.Service
{
    public interface IStudentService
    {
        bool MakeUpExamRequest(int studentId, string courseCode);
    }
    public class StudentService : IStudentService
    {
        public bool MakeUpExamRequest(int studentId, string courseCode)
        {
            
            return true;
        }
    }
}
