using Microsoft.AspNetCore.Mvc;
using ResitExam.CONTROLLERS.Service.IService;
using ResitExam.DtoObj;

namespace ResitExam.CONTROLLERS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : Controller
    {
        private readonly ICourseService _courseService;
        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpPost("AddAnnouncementToCourse")]
        public IActionResult AddAnnouncementToCourse([FromBody] AddAnnouncementRequest request)
        {
            var addResult = _courseService.AddAnnouncementToCourseByCourseID(request.Announcement, request.CourseId);
            if(addResult) return Ok("Announcement added successfully.");
            else return BadRequest("Failed to add announcement.");
        }
        [HttpPost("AddCourse")]
        public IActionResult AddCourse([FromBody] AddCourseRequest request)
        {
            var addResult = _courseService.AddCourse(request.Name,request.Code,request.InstructorId,request.HasResitExam);
            if (addResult) return Ok("Course added successfully.");
            else return BadRequest("Failed to add course.");
        }
    }

 
}
