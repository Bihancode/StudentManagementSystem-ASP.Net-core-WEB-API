using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentManagement.Models;
using StudentManagement.Servicers;

namespace StudentManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly StudentService _studentService;

        public StudentController(StudentService studentService)
        {
            _studentService = studentService;
        }

      
        [HttpPost]        
        public void CreateStudent(CreateStudentRequestViewModel request)
        {

            _studentService.CreateStudent(request.StudentId, request.StudentName, request.DateOfBirth);
            
        }
    }
}
