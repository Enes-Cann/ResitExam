using Microsoft.EntityFrameworkCore;
using ResitExam.DATABASE.InterfaceRepos;
using ResitExam.MODEL;

namespace ResitExam.DATABASE.ClassRepos;

public class CourseRepository:ICourseRepository
{
    private readonly ApplicationDbContext _context;

    public CourseRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public Course GetById(int id)
    {
        return _context.Courses.First(c => c.Id == id);

        /*.Find(id);*/
    }

    public IEnumerable<Course> GetAll()
    {
        return _context.Courses.ToList();
    }

    public void Add(Course course)
    {
        _context.Courses.Add(course);
        _context.SaveChanges();
    }

    public void Update(int id)
    {
        var course = _context.Courses.Find(id);
        _context.Courses.Update(course);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var course = _context.Courses.Find(id);
        _context.Courses.Remove(course);
        _context.SaveChanges();
    }
}