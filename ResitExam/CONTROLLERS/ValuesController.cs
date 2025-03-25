using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ResitExam.DATABASE;
using ResitExam.MODEL;

namespace ResitExam.CONTROLLERS
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> GetStudents()
        {
            return await _context.Students.ToListAsync();
        }

        [HttpPost]

        public async Task<ActionResult<Student>> PostStudent(Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetStudent", new { id = student.Id }, student);
        }
    }
    [Route("api/[controller]")]
    [ApiController]
    public class ResitExamController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ResitExamController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost("declare")]
        public async Task<IActionResult> DeclareResit([FromBody] int studentId)
        {
            var student = await _context.Students.FindAsync(studentId);
            if (student == null)
                return NotFound();

            if (student.ResitEligibility)
            {
                return Ok($"{student.Name} is eligible for the resit exam.");
            }
            return BadRequest("Student is not eligible for the resit exam.");
        }
    }

}
