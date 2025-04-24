using ResitExam.AltSınıflar;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ResitExam.MODEL;

public class Student
{
    public int Id                   { get; set; }
    public string Name              { get; set; }
    public string Email             { get; set; }
    // int StudentId
    public List<Course> Courses     { get; set; } = [];
    [JsonIgnore]
    public List<ResitExamObj> ResitExams { get; set; } = [];
    //TODO:ResitExamListesi tutacak


}