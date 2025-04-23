using ResitExam.MODEL;

public class User
{
    public int Id { get; set; }

    public string Username { get; set; }

    public string Password { get; set; }

    public int RoleId { get; set; }          
    public Role Role { get; set; }           

    public int? StudentId { get; set; }
    public Student Student { get; set; }

    public int? InstructorId { get; set; }
    public Instructor Instructor { get; set; }

    public int? SecretaryId { get; set; }
    public FacultySecretary Secretary { get; set; }
}