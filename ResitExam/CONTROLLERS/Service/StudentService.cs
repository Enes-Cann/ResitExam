using ResitExam.DATABASE.InterfaceRepos;
using ResitExam.MODEL;

namespace ResitExam.CONTROLLERS.Service;
/// <summary>
/// Öğrenci ile ilgili bütün işlemleri yöneten servis.
/// </summary>
public class StudentService : IStudentService
{
    private readonly IStudentRepository _studentRepository;

    /// <summary>
    /// Bilgisi verilen öğrencinin bütün derslerini listeler.
    /// </summary>
    /// <param name="Student">Verileri talep edilen öğrenci</param>
    /// <returns>Ders Listesi</returns>
    public List<Course> GetStudentCourseRequest(int studentId)
    {
        var courses = _studentRepository.GetById(studentId).Courses;
        return courses;
    }
    public void AssignResitExamToStudent(int studentId, int courseId)
    {
        var student = _studentRepository.GetById(studentId);
        student.TakenResitExam.Add(student.Courses.FirstOrDefault(course => course.Id == courseId)?.ResitExam);
    }

}
