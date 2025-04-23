using ResitExam.AltSınıflar;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResitExam.DtoObj;

public class AddCourseRequest
{
    public string Code { get; set; }
    public string Name { get; set; }
    public Grade FinalGrade { get; set; }
    public int InstructorId { get; set; }
    public bool? HasResitExam { get; set; }

}

