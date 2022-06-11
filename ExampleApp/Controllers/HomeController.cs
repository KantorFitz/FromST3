using Microsoft.AspNetCore.Mvc;

namespace ExampleApp.Controllers
{
	public class HomeController : Controller
	{
		// GET
		public IActionResult Index()
		{
			return View();
		}
	}
}