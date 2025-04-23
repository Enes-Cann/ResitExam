using Microsoft.EntityFrameworkCore;
using ResitExam.DATABASE.InterfaceRepos;
using ResitExam.MODEL;

namespace ResitExam.DATABASE.ClassRepos;

public class StudentRepository : IStudentRepository
{
    private readonly ApplicationDbContext _context;

    public StudentRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public Student GetById(int id)
    {
        return _context.Students
            .Include(x => x.Courses)
                .ThenInclude(x => x.ResitExam)
            .First(student => student.Id == id);
    }

    public IEnumerable<Student> GetAll()
    {
        return _context.Students.ToList();
    }

    public void Add(Student student)
    {
        //var student = _context.Students.Find(id);
        _context.Students.Add(student);
        _context.SaveChanges();
    }

    public void Update(Student student)
    {
        Student? studentToUpdate = _context.Students.Find(student.Id);
        studentToUpdate = student;
        _context.Students.Update(studentToUpdate);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var student = _context.Students.Find(id);
        _context.Students.Remove(student);
        _context.SaveChanges();
    }
}
