using ResitExam.DATABASE.InterfaceRepos;
using ResitExam.MODEL;

namespace ResitExam.DATABASE.ClassRepos;

/// <summary>
/// Sınava girecek öğrencileri kaydeden, güncelleyen ve silen sınıf.
/// </summary>
public class ResitExamRepository : IResitExamRepository
{
    private readonly ApplicationDbContext _context;

    public void Add(int id)
    {
        var resitExam = _context.ResitExams.Find(id);
        _context.ResitExams.Add(resitExam);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
       var resitExam = _context.ResitExams.Find(id);
        _context.ResitExams.Remove(resitExam);
        _context.SaveChanges();
    }

    public IEnumerable<ResitExamObj> GetAll()
    {
       return _context.ResitExams.ToList();
    }

    public ResitExamObj GetById(int id)
    {
        return _context.ResitExams.Find(id);
    }

    public void Update(int id)
    {
       var resitExam = _context.ResitExams.Find(id);
        _context.ResitExams.Update(resitExam);
        _context.SaveChanges();
    }
}