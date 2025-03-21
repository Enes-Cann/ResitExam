namespace ResitExam.MODEL
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public string Email { get; set; }   

       /* public Dictionary<string, string> Grades { get; set; } = new Dictionary <string, string>();*/ // Ders = Not 

        public bool ResitEligibility { get; set; } = false;

        public void DeclareResitExam(string courseCode)
        {
            
        }
    }
}