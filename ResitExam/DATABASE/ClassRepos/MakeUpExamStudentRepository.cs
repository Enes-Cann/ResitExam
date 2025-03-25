using ResitExam.DATABASE.InterfaceRepos;
using ResitExam.MODEL;

namespace ResitExam.DATABASE.ClassRepos
{
    public class MakeUpExamStudentRepository : IMakeUpExamStudentRepository
    {
        private readonly ApplicationDbContext _context;

        public void Add(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }

        public void Delete(int studentId)
        {
            var student = _context.Students.Find(studentId);
            _context.Students.Remove(student);
            _context.SaveChanges();
        }

        public IEnumerable<Student> GetAll()
        {
            return _context.Students.ToList();
        }

        public Student GetById(int studentId)
        {
            return _context.Students.Find(studentId);
        }

        public void Update(Student student)
        {
            _context.Students.Update(student);
            _context.SaveChanges();
        }
    }
}
