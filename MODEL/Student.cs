using ResitExam.AltSınıflar;
using System.ComponentModel.DataAnnotations;

namespace ResitExam.MODEL;

public class Student
{
    public int Id                   { get; set; }
    public string Name              { get; set; }
    public string Email             { get; set; }
    // int StudentId
    public List<Course> Courses     { get; set; } = [];
    //TODO:ResitExamListesi tutacak
    public ICollection<CourseStudent> CourseStudents { get; set; }


}