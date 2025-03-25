using ResitExam.DATABASE.InterfaceRepos;
using ResitExam.MODEL;

namespace ResitExam.DATABASE.ClassRepos;

//public class MakeUpExamCourseRepository : IMakeUpExamCourseRepository
//{
//    private readonly ApplicationDbContext _context;
//    public void Add(int examId)
//    {
//        var exam = _context.MakeUpExams.Find(examId);
//        _context.MakeUpExams.Add(exam);
//        _context.SaveChanges();
//    }
//    public void Update(int examId)
//    {
//        var exam = _context.MakeUpExams.Find(examId);
//        _context.MakeUpExams.Update(exam);
//        _context.SaveChanges();
//    }
//    public void Delete(int examId)
//    {
//        var exam = _context.MakeUpExams.Find(examId);
//    }

//    public IEnumerable<MakeUpExam> GetAll()
//    {
//        return _context.MakeUpExams.ToList();
//    }

//    public MakeUpExam GetById(int examId)
//    {
//        return _context.MakeUpExams.Find(examId);
//    }

   
}
