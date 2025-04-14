using ResitExam.MODEL;

namespace ResitExam.DATABASE.InterfaceRepos;

public interface IResitExamRepository
{
    ResitExamObj GetById(int id);
    IEnumerable<ResitExamObj> GetAll();
    void Add(int id);
    void Update(int id);
    void Delete(int id);

}