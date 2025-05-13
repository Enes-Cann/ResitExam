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
  

        //[HttpPost("AddAnnouncementToCourse")] //DTO kullanılıyor
        //public IActionResult AddAnnouncementToCourse([FromBody] AddAnnouncementRequest request)
        //{
        //    var addResult = _courseService.AddAnnouncementToCourseByCourseID(request.Announcement, request.CourseId);
        //    if (addResult) return Ok("Announcement added successfully.");
        //    else return BadRequest("Failed to add announcement.");
        //}

        //TODO:Migration yapılmadı database de gösterilemez

        /// <summary>
        /// Kurs ID'sine göre öğrenci listesini döndürür.
        /// </summary>
        /// <param name="courseId"></param>
        /// <returns></returns>
        [HttpGet("GetStudentListByCourseId")]
        public IActionResult GetStudentListByCourseId([FromQuery] int courseId)
        {
            try
            {
                var studentList = _courseService.GetStudentListByCourseId(courseId);

                if (studentList != null && studentList.Count > 0)
                    return Ok(studentList);
                else
                    return NotFound("No students found for this course.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"💥 Internal Server Error: {ex.Message}");
            }
        }
        [HttpGet("GetCoursesByInstructorId")]
public IActionResult GetCoursesByInstructorId([FromQuery] int instructorId)
{
    try
    {
        var courses = _courseService.GetAllCourses()
            .Where(c => c.InstructorId == instructorId)
            .Select(c => new {
                c.Id,
                c.CourseCode,
                c.Name
            })
            .ToList();

        return Ok(courses);
    }
    catch (Exception ex)
    {
        return StatusCode(500, $"Internal Server Error: {ex.Message}");
    }
}

[HttpPost("UpdateStudentGrade")]
public IActionResult UpdateStudentGrade([FromBody] CourseStudentUpdateDto model)
{
    var result = _courseService.UpdateStudentGrade(model);

    if (!result)
        return NotFound("Öğrenci bu derse kayıtlı değil.");

    return Ok(new { message = "Not başarıyla güncellendi." });
}


    }

 
}
