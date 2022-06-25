using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ExamampleApp2Approach.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ExamampleApp2Approach.Models;
using ExamampleApp2Approach.Service;
using ExampleApp.Model;

namespace ExamampleApp2Approach.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			var result = new HardwareService().GetHardware();
			return View(result);
		}

		public IActionResult Add()
		{
			ViewBag.Companies = new HardwareModel().Companies;
			return View();
		}

		[HttpPost]
		public IActionResult Add(Hardware hardware)
		{
			new HardwareService().Add(hardware);
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}