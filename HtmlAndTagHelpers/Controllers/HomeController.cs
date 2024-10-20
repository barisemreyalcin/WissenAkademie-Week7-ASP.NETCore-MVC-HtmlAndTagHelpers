using System.Diagnostics;
using HtmlAndTagHelpers.Models;
using Microsoft.AspNetCore.Mvc;

namespace HtmlAndTagHelpers.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private List<Student> students; // ��renci list olu�turdum

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;

			students = new List<Student>() // Bu datay� Index view'a g�ndermek istiyorum
			{
				new Student(){StudentID=101, StudentName="John Doe", Branch="SWE", Gender="Male", Section="A"},
				new Student(){StudentID=102, StudentName="Jane Doe", Branch="SWE", Gender="Female", Section="A"},
				new Student(){StudentID=103, StudentName="Max Doe", Branch="HWE", Gender="Male", Section="B"},
				new Student(){StudentID=104, StudentName="Sarah Doe", Branch="HWE", Gender="Female", Section="B"},
			};
		}

		public IActionResult Index()
		{
			// Modelim burada bir liste. Bunu g�nderece�im
			return View(students); // view'a bu liste obj olarak gidecek
			// G�ndermem yeterli de�il, view'�n da bunu bilmesi laz�m
		}
        public IActionResult IndexList()
        {
            return View(students);
        }

        public IActionResult StudentDetail(int id)
        {
			var student = students.FirstOrDefault(x => x.StudentID == id); // automatic binding
			return View(student);
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
