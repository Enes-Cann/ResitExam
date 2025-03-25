using ResitExam.MODEL;

namespace ResitExam.DATABASE.InterfaceRepos
{
    public interface IMakeUpExamStudentRepository
    {
        void Add(Student student);
        void Update(Student student);
        void Delete(int studentId);
        IEnumerable<Student> GetAll();
        Student GetById(int student);

    }
}
