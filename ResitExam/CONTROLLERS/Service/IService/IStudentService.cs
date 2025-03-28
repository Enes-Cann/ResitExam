using ResitExam.DtoObj;
using ResitExam.MODEL;

namespace ResitExam.CONTROLLERS.Service;

public interface IStudentService
{
    List<Course> GetStudentCourseRequest(int studentId);
    void AssignResitExamToStudent(int studentId, int courseId);
}
