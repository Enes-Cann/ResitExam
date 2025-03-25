using ResitExam.MODEL;

namespace ResitExam.DATABASE.InterfaceRepos
{
    public interface ICourseRepository
    {
        Course GetByCode(string courseCode);
        IEnumerable<Course> GetAll();
        void Add(string courseCode);
        void Update(string courseCode);
        void Delete(string courseCode);
    }
}
