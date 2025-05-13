
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
    public int StudentId        { get; set; }//TODO: resitexamın student ıd tutmayacak değiştirilecek
         //stirng Announcement
    public string ExamDetails   { get; set; }//TODO: ExamDetails announcemente benzetilecek
    public Grade? ResitGrade    { get; set; }

    public DateTime? ExamTime   { get; set; }
    //public List<Student> Students { get; set; } = [];

    //ali öğretmenin matematik dersinin büt sınavının öğrencileri 


}