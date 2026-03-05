using Microsoft.AspNetCore.Mvc;
using naifar.Application.Services;
using naifar.Domain;

namespace NaiFar.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly StudentService _service;
        private IConfiguration _iConfig;
        public StudentController(IConfiguration config)
        {
            _iConfig = config;
            string connectionString = _iConfig.GetConnectionString("pxlTestDB");
            _service = new StudentService(connectionString);
        }
        [HttpGet]
        public ActionResult<List<Student>> Get()
        {
            var result = _service.GetStudents();
            return Ok(result.Rows);
        }
        [HttpPost]
        public IActionResult Post([FromBody] Student student)
        {
            _service.AddStudent(student.FirstName, student.LastName);
            return Ok();
        }

        //[HttpPost("delete")]
        //public IActionResult Delete(int id)
        //{
        //    _service.DeleteStudent(id);
        //    return Ok();
        //}
    }
}
