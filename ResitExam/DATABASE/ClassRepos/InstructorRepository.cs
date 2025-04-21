using Microsoft.EntityFrameworkCore;
using ResitExam.DATABASE.InterfaceRepos;
using ResitExam.MODEL;

namespace ResitExam.DATABASE.ClassRepos
{
    public class InstructorRepository(ApplicationDbContext context) : IInstructorRepository
    {
        private readonly ApplicationDbContext _context = context;

        public Instructor GetInstructorById(int id)
        {
            return _context.Instructors
                .Include(x => x.Courses)
                    .ThenInclude(x => x.ResitExam)
                .First(instructor => instructor.Id == id);
        }
    }
}
