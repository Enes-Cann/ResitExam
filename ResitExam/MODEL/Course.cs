using System.ComponentModel.DataAnnotations;

namespace ResitExam.MODEL;

public class Course
{
    [Key]
    public string CourseCode { get; set; }
    public string CourseName { get; set; }
    public Instructor AssignedInstructor { get; set; }
    public List<Grade> Grades { get; set; }
    public bool MakeUpExamIsActive { get; set; }

}