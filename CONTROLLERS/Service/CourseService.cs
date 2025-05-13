using ResitExam.AltSınıflar;
using ResitExam.CONTROLLERS.Service.IService;
using ResitExam.DATABASE;
using ResitExam.DATABASE.ClassRepos;
using ResitExam.DATABASE.InterfaceRepos;
using ResitExam.DtoObj;
using ResitExam.MODEL;

namespace ResitExam.CONTROLLERS.Service
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IInstructorRepository _instructorRepository;
        private readonly ApplicationDbContext _context;

        public CourseService(
            ICourseRepository courseRepository,
            IInstructorRepository instructorRepository,
            ApplicationDbContext context)
        {
            _courseRepository = courseRepository;
            _instructorRepository = instructorRepository;
            _context = context;
        }

        public List<Course> GetAllCourses()
        {
            return _courseRepository.GetAll().ToList();
        }

        public List<StudentWithGradeDto> GetStudentListByCourseId(int courseId)
        {
            var studentList = _context.CourseStudents
                .Where(cs => cs.CourseId == courseId)
                .Select(cs => new StudentWithGradeDto
                {
                    Id = cs.Student.Id,
                    Name = cs.Student.Name,
                    Email = cs.Student.Email,
                    LetterGrade = cs.LetterGrade.HasValue ? cs.LetterGrade.ToString() : ""
                })
                .ToList();

            return studentList;
        }
        public bool UpdateStudentGrade(CourseStudentUpdateDto model)
{
    var courseStudent = _context.CourseStudents
        .FirstOrDefault(cs => cs.CourseId == model.CourseId && cs.StudentId == model.StudentId);

    if (courseStudent == null)
        return false;

    courseStudent.LetterGrade = model.LetterGrade;
    _context.SaveChanges();
    return true;
}

    }
}
