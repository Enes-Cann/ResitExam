
using System.ComponentModel.DataAnnotations;

namespace ResitExam.MODEL;

public class Course
{
    public int Id                 { get; set; }
    public string CourseCode      { get; set; }
    public string Name            { get; set; }
    public string Announcements   { get; set; }
    public Instructor Instructor  { get; set; }
    public ResitExamObj ResitExam { get; set; }
    public List<Student> Students { get; set; } = [];
    public bool HasResitExam      { get; set; }
}