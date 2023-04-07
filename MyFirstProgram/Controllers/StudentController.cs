using Microsoft.AspNetCore.Mvc;
using MyFirstProgram.Data;

namespace MyFirstProgram.Controllers
{
	
	public class StudentController : Controller
	{
		private ApplicationDbContext _context;
			public StudentController(ApplicationDbContext context)
		{
		     _context= context;
		}
		[HttpGet]
			public IActionResult Index()
		{
			var students= _context.Students.ToList();

			return View(students);
		}
	}
}
