using StudentManagement.Entitty;

namespace StudentManagement.Servicers
{
    
    public class StudentService
    {
        public List<Student> Students = new List<Student>();
       
        public void CreateStudent(int studentId, string studentName, DateTime dateOfBirth) 
        {
            Student student = new Student()
            {
                StudentId = studentId,
                StudentName = studentName, 
                DateOfBirth = dateOfBirth,
            };

            Students.Add(student);
        }
    }
}
