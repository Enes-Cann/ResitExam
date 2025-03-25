using Microsoft.AspNetCore.Mvc;
using ResitExam.DATABASE;

namespace ResitExam.CONTROLLERS;

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

        if (student.MakeUpExamIsActive)
        {
            return Ok($"{student.Name} is eligible for the resit exam.");
        }

        return BadRequest("Student is not eligible for the resit exam.");
    }
}