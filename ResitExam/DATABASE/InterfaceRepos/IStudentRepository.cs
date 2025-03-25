using ResitExam.MODEL;

namespace ResitExam.DATABASE.InterfaceRepos
{
    public interface IStudentRepository
    {
        Student GetById(int studentId);
        IEnumerable<Student> GetAll();
        void Add(int studentId);
        void Update(int studentId);
        void Delete(int studentId);
    }
}
