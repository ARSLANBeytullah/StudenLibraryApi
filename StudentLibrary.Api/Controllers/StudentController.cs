using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentLibrary.Core.Services;

namespace StudentLibrary.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
    }
}
