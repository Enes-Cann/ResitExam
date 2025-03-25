using Microsoft.EntityFrameworkCore;
using ResitExam.CONTROLLERS;
using ResitExam.DATABASE.InterfaceRepos;
using ResitExam.MODEL;

namespace ResitExam.DATABASE.ClassRepos
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext _context;

        public StudentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Student GetById(int studentId)
        {
            return _context.Students.Find(studentId);
        }
        public IEnumerable<Student> GetAll()
        {
            return _context.Students.ToList();
        }
        public void Add(int studentId)
        {
            var student = _context.Students.Find(studentId);
            _context.Students.Add(student);
            _context.SaveChanges();
        }
        public void Update(int studentId)
        {
            var student = _context.Students.Find(studentId);
            _context.Students.Update(student);
            _context.SaveChanges();
        }
        public void Delete(int studentId)
        {
            var student = _context.Students.Find(studentId);
            _context.Students.Remove(student);
            _context.SaveChanges();
        }
    }
}
