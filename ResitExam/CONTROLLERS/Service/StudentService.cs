using ResitExam.DATABASE.InterfaceRepos;
using ResitExam.MODEL;

namespace ResitExam.CONTROLLERS.Service;
/// <summary>
/// Öğrenci ile ilgili bütün işlemleri yöneten servis.
/// </summary>
public class StudentService(IStudentRepository studentRepository) : IStudentService
{
    private readonly IStudentRepository _studentRepository = studentRepository;

    /// <summary>
    /// Bilgisi verilen öğrencinin bütün derslerini listeler.
    /// </summary>
    /// <param name="Student">Verileri talep edilen öğrenci</param>
    /// <returns>Ders Listesi</returns>
    public List<Course> GetAllCoursesListByStudent(int studentId)
    {
        return _studentRepository
            .GetById(studentId).Courses;
    }

    //public bool RemoveResitExamFromStudent(int studentId, int courseId)
    //{
    //    var student = _studentRepository
    //        .GetById(studentId);
    //    student.TakenResitExam.RemoveAll(x => x.CourseId == courseId);
    //    _studentRepository.Update(student);
    //    return true;
    //}
}
