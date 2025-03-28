using ResitExam.MODEL;

namespace ResitExam.DATABASE.InterfaceRepos
{
    public interface IStudentRepository
    {
        Student GetById(int id);
        IEnumerable<Student> GetAll();
        void Add(int id);
        void Update(int id);
        void Delete(int id);
    }
}