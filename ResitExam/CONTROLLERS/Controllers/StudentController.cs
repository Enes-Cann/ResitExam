using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ResitExam.CONTROLLERS.Service;
using ResitExam.DtoObj;
using ResitExam.MODEL;

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
        [HttpPost("GetAllCoursesByStudent")]
        public IActionResult ResitExamRequest([FromBody] GetAllCoursesRequest dto) //Dtoda bulunur "int StudentId -- string CourseCode"
        {
            return Ok(_studentService.GetAllCoursesListByStudent(dto.StudentId));
          
        }
       

    }
}
