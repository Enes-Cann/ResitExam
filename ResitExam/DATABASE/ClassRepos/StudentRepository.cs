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
        return _context.Students.Find(id);
    }

    public IEnumerable<Student> GetAll()
    {
        return _context.Students.ToList();
    }

    public void Add(int id)
    {
        var student = _context.Students.Find(id);
        _context.Students.Add(student);
        _context.SaveChanges();
    }

    public void Update(int id)
    {
        var student = _context.Students.Find(id);
        _context.Students.Update(student);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var student = _context.Students.Find(id);
        _context.Students.Remove(student);
        _context.SaveChanges();
    }
}
