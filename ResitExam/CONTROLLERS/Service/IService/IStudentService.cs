using ResitExam.DtoObj;
using ResitExam.MODEL;

namespace ResitExam.CONTROLLERS.Service;

public interface IStudentService
{
    List<Course> GetAllCoursesListByStudent(int studentId);
    //bool RemoveResitExamFromStudent(int studentId, int courseId);
    void AddCourseByStudentId(int studentId, int courseId);
    void IsStudentTakeResitExam(int studentId);
}
