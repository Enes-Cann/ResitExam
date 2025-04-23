using ResitExam.MODEL;

namespace ResitExam.DATABASE.InterfaceRepos
{
    public interface IInstructorRepository
    {
        public Instructor GetInstructorById(int id);

    }
}