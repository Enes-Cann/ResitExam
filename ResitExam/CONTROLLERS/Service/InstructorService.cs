using ResitExam.CONTROLLERS.Service.IService;
using ResitExam.DATABASE.ClassRepos;
using ResitExam.DATABASE.InterfaceRepos;
using ResitExam.MODEL;

namespace ResitExam.CONTROLLERS.Service
{
    public class InstructorService(IInstructorRepository instructorRepository) : IInstructorService
    {
        private readonly IInstructorRepository _instructorRepository = instructorRepository;
        public Instructor GetInstructorById(int id)
        {
            return _instructorRepository.GetInstructorById(id);
        }
    }
}
