using Microsoft.AspNetCore.Mvc;

namespace MyFirstProgram.Controllers
{
	public class TeacherController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult Distpaly()
		{
			return View();
		}
	}
}
