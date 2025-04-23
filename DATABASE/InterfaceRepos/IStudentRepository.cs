using ResitExam.MODEL;

namespace ResitExam.DATABASE.InterfaceRepos
{
    public interface IStudentRepository
    {
        Student GetById(int id);
        IEnumerable<Student> GetAll();
        void Add(Student student);
        void Update(Student student);
        void Delete(int id);
    }
}