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
        /// <summary>
        /// Öğrencinin aldığı tüm dersleri listeleme işlemi EndPointi
        /// </summary>
        /// <param name="studentId"></param>
        /// <returns></returns>
        [HttpGet("GetAllCoursesByStudent")]
        public IActionResult GetAllCoursesByStudentRequest([FromQuery] int studentId) 
        {
            return Ok(_studentService.GetAllCoursesListByStudent(studentId));
          
        }
       

        //TODO:ResitExam butondan gelen değere göre resit exam list oluşturalacak
    }
}
