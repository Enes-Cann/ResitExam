using ResitExam.MODEL;

namespace ResitExam.DATABASE.InterfaceRepos
{
    public interface ICourseRepository
    {
        Course GetByCode(string courseCode);
        IEnumerable<Course> GetAll();
        void Add(Course course);
        void Update(Course course);
        void Delete(string courseCode);
    }
}
