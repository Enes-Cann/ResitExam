using ResitExam.DtoObj;

namespace ResitExam.CONTROLLERS.Service
{
    public interface IStudentService
    {
        List<CourseDto> GetAllCoursesListByStudent(int studentId);
        void IsStudentTakeResitExam(int studentId);
        List<StudentCourseResitDto> GetStudentResitGrades(int studentId);
    }
}
