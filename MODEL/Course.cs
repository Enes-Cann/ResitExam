
using ResitExam.AltSınıflar;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ResitExam.MODEL;

public class Course
{
    public int Id                       { get; set; }
    public string CourseCode            { get; set; }
    public string Name                  { get; set; }
    public Instructor Instructor        { get; set; }
    public int InstructorId             { get; set; }
    public ResitExamObj ResitExam       { get; set; }
    [JsonIgnore]
    public List<Student> Students       { get; set; } = [];
    public Grade? FinalGrade            { get; set; }
    public bool? HasResitExamButton      { get; set; } 
   public ICollection<CourseStudent> CourseStudents { get; set; }

}