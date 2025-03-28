
using ResitExam.AltSınıflar;
using System.ComponentModel.DataAnnotations;

namespace ResitExam.MODEL;

/// <summary>
/// Büt. Sınavı
/// </summary>
public class ResitExamObj
{
    public int Id               { get; set; }
    public int CourseId         { get; set; }
    public string ExamDetails   { get; set; }
    public DateTime? ExamTime    { get; set; }
    public Grade? Grade { get; set; }
    public int StudentId { get; set; }
    //public Course Course        { get; set; }
}