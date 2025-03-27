using ResitExam.DATABASE;
using ResitExam.DATABASE.InterfaceRepos;
using ResitExam.DtoObj;

namespace ResitExam.Service;

public class MakeUpExamStudentRegisterService : IStudentService
{
    private readonly IStudentRepository _studentRepository;
    private readonly ICourseRepository _courseRepository;
    //private readonly IMakeUpExamCourseRepository _makeUpExamCourseRepository;
    private readonly IResitExamStudentRepository _makeUpExamStudentRepository;
    private readonly ApplicationDbContext applicationDbContext;

    public MakeUpExamStudentRegisterService(IStudentRepository studentRepository, ICourseRepository courseRepository)
    {
        _courseRepository = courseRepository;
        _studentRepository = studentRepository;
    }

    public bool MakeUpExamRequest(MakeUpExamRequestDto dto)
    {
        //Repolardan öğrenciyi ve dersi getirir.
        var student = _studentRepository.GetById(dto.StudentId);
        var course = _courseRepository.GetByCode(dto.CourseCode);

        //Gelen öğrenci ve dersin validasyonlarını yapar.
        if (student == null || course == null) return false;
        if (!student.MakeUpExamIsActive || !course.MakeUpExamIsActive) return false;

        //Öğrenci ve dersin make up sınavına kaydını yapar.
        _makeUpExamStudentRepository.Add(student);
        applicationDbContext.SaveChanges();
        //Test yazmam lazım buraya

        return true;
    }
}
