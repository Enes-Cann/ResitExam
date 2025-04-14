using Microsoft.AspNetCore.Mvc;
using ResitExam.CONTROLLERS.Service;

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
        
        [HttpGet("GetAllCoursesByStudent")]
        public IActionResult GetAllCoursesByStudentRequest([FromQuery] int studentId) //Dtoda bulunur "int StudentId -- string CourseCode"
        {
            return Ok(_studentService.GetAllCoursesListByStudent(studentId));
          
        }
       

    }
}
