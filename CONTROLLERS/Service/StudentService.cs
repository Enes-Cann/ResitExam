using ResitExam.AltSınıflar;
using ResitExam.DATABASE.InterfaceRepos;
using ResitExam.MODEL;
using ResitExam.DtoObj;
using Microsoft.EntityFrameworkCore;
using ResitExam.DATABASE;

namespace ResitExam.CONTROLLERS.Service;

/// <summary>
/// Öğrenci ile ilgili bütün işlemleri yöneten servis.
/// </summary>
public class StudentService : IStudentService
{
    private readonly ApplicationDbContext _context;

    private readonly IStudentRepository _studentRepository;
    private readonly ICourseRepository _courseRepository;

    public StudentService(IStudentRepository studentRepository, ICourseRepository courseRepository,
    ApplicationDbContext context)
    {
        _studentRepository = studentRepository;
        _courseRepository = courseRepository;
         _context = context; 
    }

    /// <summary>
    /// IDsi verilen öğrencinin derslerini listeler.
    /// </summary>
public List<CourseDto> GetAllCoursesListByStudent(int studentId)
{
    var student = _context.Students
        .Include(s => s.Courses)
        .Include(s => s.CourseStudents)
        .FirstOrDefault(s => s.Id == studentId);

    if (student == null)
        throw new Exception("Student not found");

    var courseDtos = student.Courses.Select(course =>
    {
        var courseStudent = student.CourseStudents
            .FirstOrDefault(cs => cs.CourseId == course.Id);

        var grade = courseStudent?.LetterGrade.ToString() ?? "N/A";

        return new CourseDto
        {
            Id = course.Id,
            CourseCode = course.CourseCode,
            Name = course.Name,
            Grade = grade,
            HasResitExamButton = true
        };
    }).ToList();

    return courseDtos;
}

    public void IsStudentTakeResitExam(int studentId)
    {
        var studentCourses = _studentRepository.GetById(studentId).Courses;

        foreach (var course in studentCourses)
        {
            if (course.FinalGrade == Grade.AA ||
                course.FinalGrade == Grade.BA ||
                course.FinalGrade == Grade.BB ||
                course.FinalGrade == Grade.CB)
            {
                course.HasResitExamButton = false;
            }
            else
            {
                course.HasResitExamButton = true;
            }
        }
    }

    /// <summary>
    /// Öğrencinin derslerine ait ResitGrade bilgisini getirir.
    /// </summary>
   public List<StudentCourseResitDto> GetStudentResitGrades(int userId)
{
    // Kullanıcının öğrenci kimliği alınır
    var studentId = _context.Users
        .Where(u => u.Id == userId)
        .Select(u => u.StudentId)
        .FirstOrDefault();

    if (studentId == null || studentId == 0)
        throw new Exception("StudentId not found for user.");

    // Öğrenci dersleri CourseStudent ve Course üzerinden alınır
    var grades = _context.CourseStudents
        .Include(cs => cs.Course)
        .Where(cs => cs.StudentId == studentId)
        .Select(cs => new StudentCourseResitDto
        {
            CourseCode = cs.Course.CourseCode,
            CourseName = cs.Course.Name,
            Grade = cs.LetterGrade.ToString()
        })
        .ToList();

    return grades;
}


}

/// <summary>
/// Öğrencinin dersi ve büt notu bilgisi
/// </summary>
public class StudentCourseResitDto
{
    public string CourseCode { get; set; }
    public string CourseName { get; set; }
    public string Grade { get; set; }
}  

/// <summary>
/// Course için DTO
/// </summary>
public class CourseDto
{
    public int Id { get; set; }
    public string CourseCode { get; set; }
    public string Name { get; set; }
    public string Grade { get; set; }
    public bool HasResitExamButton { get; set; }
}
