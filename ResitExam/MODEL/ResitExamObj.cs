
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
        
    public string ExamDetails   { get; set; } //stirng Announcement
    public DateTime? ExamTime   { get; set; }
    public int StudentId { get; set; }
    public List<Student> Students { get; set; } = [];
    public List<Announcement> Announcements { get; set; } = [];


    //ali öğretmenin matematik dersinin büt sınavının öğrencileri 


}