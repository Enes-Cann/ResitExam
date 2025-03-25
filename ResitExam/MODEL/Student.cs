using System.ComponentModel.DataAnnotations;

namespace ResitExam.MODEL;

public class Student
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public List<Grade> Grades { get; set; }
    public bool MakeUpExamIsActive { get; set; }
}