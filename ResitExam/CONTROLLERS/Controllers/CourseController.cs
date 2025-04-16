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
        /// <summary>
        /// Kurs ekleme işlemi
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns> DENEME ENDPOİNTİ
        [HttpPost("AddCourse")]
        public IActionResult AddCourse([FromBody] AddCourseRequest request)
        {
            var addResult = _courseService.AddCourse(request.Name, request.Code, request.InstructorId, request.FinalGrade, request.HasResitExam);
            if (addResult) return Ok("Course added successfully.");
            else return BadRequest("Failed to add course.");
        }

        /// <summary>
        /// Kursa duyuru ekleme işlemi
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("AddAnnouncementToCourse")] //DTO kullanılıyor
        public IActionResult AddAnnouncementToCourse([FromBody] AddAnnouncementRequest request)
        {
            var addResult = _courseService.AddAnnouncementToCourseByCourseID(request.Announcement, request.CourseId);
            if(addResult) return Ok("Announcement added successfully.");
            else return BadRequest("Failed to add announcement.");
        }
        
        //TODO:Migration yapılmadı database de gösterilemez

        /// <summary>
        /// Kurs ID'sine göre öğrenci listesini döndürür.
        /// </summary>
        /// <param name="courseId"></param>
        /// <returns></returns>
        [HttpGet("GetStudentListByCourseId")]
        public IActionResult GetStudentListByCourseId([FromQuery] int courseId)
        {
            var studentList = _courseService.GetStudentListByCourseId(courseId);
            if (studentList != null && studentList.Count > 0)
                return Ok(studentList);
            else
                return NotFound("No students found for this course.");
        }
    }

 
}
