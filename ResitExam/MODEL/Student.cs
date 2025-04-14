using ResitExam.AltSınıflar;
using System.ComponentModel.DataAnnotations;

namespace ResitExam.MODEL;

public class Student
{
    public int Id                   { get; set; }
    public string Name              { get; set; }
    public string Email             { get; set; }
    //public bool WillTakeTheExam     { get; set; }
    //public bool CanTakeTheExam      { get; set; }
   
    public List<Course> Courses         { get; set; } = [];
    public List<ResitExamObj> TakenResitExam { get; set; } = [];
}