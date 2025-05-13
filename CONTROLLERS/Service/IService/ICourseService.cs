using ResitExam.AltSınıflar;
using ResitExam.DtoObj;
using ResitExam.MODEL;

namespace ResitExam.CONTROLLERS.Service.IService
{
    public interface ICourseService
    {
        //bool AddAnnouncementToCourseByCourseID(string announcement, int courseId);
       List<StudentWithGradeDto> GetStudentListByCourseId(int courseId);

List<Course> GetAllCourses();
bool UpdateStudentGrade(CourseStudentUpdateDto model);
    }

}
