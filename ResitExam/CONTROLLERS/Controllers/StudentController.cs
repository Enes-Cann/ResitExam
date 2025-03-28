using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ResitExam.CONTROLLERS.Service;
using ResitExam.DtoObj;

namespace ResitExam.CONTROLLERS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpPost("ResitExamRequest")]
        public IActionResult ResitExamRequest([FromBody] ResitExamRequestDto dto) //Dtoda bulunur "int StudentId -- string CourseCode"

        {
            var response = _studentService.ResitExamRequest(dto);
            if (response)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
