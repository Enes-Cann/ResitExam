using ResitExam.DATABASE.InterfaceRepos;
using ResitExam.MODEL;

namespace ResitExam.DATABASE.ClassRepos
{
    public class CourseRepository:ICourseRepository
    {
        private readonly ApplicationDbContext _context;

        public CourseRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Course GetByCode(string courseCode)
        {
            return _context.Courses.Find(courseCode);
        }
        public IEnumerable<Course> GetAll()
        {
            return _context.Courses.ToList();
        }
        public void Add(string courseCode)
        {
            var course = _context.Courses.Find(courseCode);
            _context.Courses.Add(course);
            _context.SaveChanges();
        }
        public void Update(string courseCode)
        {
            var course = _context.Courses.Find(courseCode);
            _context.Courses.Update(course);
            _context.SaveChanges();
        }
        public void Delete(string courseCode)
        {
            var course = _context.Courses.Find(courseCode);
            _context.Courses.Remove(course);
            _context.SaveChanges();
        }
    }
}
