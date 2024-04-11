namespace StudentManagement.Models
{
    public class CreateStudentRequestViewModel
    {
        public int StudentId { get; set; }

        public string StudentName { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
}
