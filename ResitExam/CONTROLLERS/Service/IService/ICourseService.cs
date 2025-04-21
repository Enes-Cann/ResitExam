using ResitExam.AltSınıflar;
using ResitExam.MODEL;

namespace ResitExam.CONTROLLERS.Service.IService
{
    public interface ICourseService
    {
        //bool AddAnnouncementToCourseByCourseID(string announcement, int courseId);
        List<Student> GetStudentListByCourseId(int courseId);

    }
}
