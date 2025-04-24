using ResitExam.AltSınıflar;
using ResitExam.DATABASE.InterfaceRepos;
using ResitExam.MODEL;

namespace ResitExam.CONTROLLERS.Service;
/// <summary>
/// Öğrenci ile ilgili bütün işlemleri yöneten servis.
/// </summary>
public class StudentService(IStudentRepository studentRepository,
                            ICourseRepository courseRepository) : IStudentService
{
    private readonly IStudentRepository _studentRepository = studentRepository;
    private readonly ICourseRepository  _courseRepository  = courseRepository;

    /// <summary>
    /// IDsi verilen öğrencinin derslerini listeler.
    /// </summary>
    /// <param name="Student">Verileri talep edilen öğrenci</param>
    /// <returns>Ders Listesi</returns>
    public List<Course> GetAllCoursesListByStudent(int studentId)
    {
        return _studentRepository
            .GetById(studentId).Courses;
    }

    /// <summary>
    /// Öğrencinin aldığı derslerin notlarını kontrol eder ve
    /// notuna göre ResitExam butonunu pasifleştirir.
    /// </summary>
    /// <param name="studentId"></param>
    //EndPointi Yok çünkü bir swagger sorgusu değil.
    public void IsStudentTakeResitExam(int studentId)
    {
      
        var studentCourses=_studentRepository
            .GetById(studentId).Courses;
        
        foreach (var course in studentCourses)
        {
            if (course.FinalGrade == Grade.AA)
            {
                course.HasResitExamButton = false;
            }
           else if (course.FinalGrade == Grade.AB)
            {
                course.HasResitExamButton = false;
            }
            else if (course.FinalGrade == Grade.BB)
            {
                course.HasResitExamButton = false;
            }
            else if (course.FinalGrade == Grade.BC)
            {
                course.HasResitExamButton = false;
            }
            else
            {
                course.HasResitExamButton = true;
            }
        }
        
    }

}
