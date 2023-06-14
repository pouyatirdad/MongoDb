using Microsoft.AspNetCore.Mvc;
using MongoDb.Models;
using MongoDb.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MongoDb.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class StudentController : ControllerBase
	{
		private readonly IStudentService studentService;

		public StudentController(IStudentService studentService)
        {
			this.studentService = studentService;
		}
        // GET: api/<StudentController>
        [HttpGet]
		public ActionResult<IEnumerable<Student>> Get()
		{
			return studentService.Get();
		}

		// GET api/<StudentController>/5
		[HttpGet("{id}")]
		public ActionResult<Student> Get(string id)
		{
			return studentService.Get(id);
		}

		// POST api/<StudentController>
		[HttpPost]
		public void Post([FromBody] Student value)
		{
			studentService.Create(value);
		}

		// PUT api/<StudentController>/5
		[HttpPut("{id}")]
		public void Put(string id, [FromBody] Student value)
		{
			studentService.Update(id,value);
		}

		// DELETE api/<StudentController>/5
		[HttpDelete("{id}")]
		public void Delete(string id)
		{
			studentService.Remove(id);
		}
	}
}
