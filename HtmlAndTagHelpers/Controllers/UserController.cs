using HtmlAndTagHelpers.Models;
using Microsoft.AspNetCore.Mvc;

namespace HtmlAndTagHelpers.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

		// Controller to View
		public IActionResult HtmlHelpers() 
        {
            // Şimdi buraya bir user göndericem
            User user = new User()
            {
                Username = "kanedoe",
                Password = "123456",
                FirstName = "Kane",
				LastName = "Doe",
                RememberMe = true
            };

            return View(user); // bunu view'a yolladım ama yeterli değil, view'a git ve oranın ne beklediğini söyle 
        }

		// View to Controller
		[HttpPost]
		public IActionResult HtmlHelpers(User _user)
		{
			// form'da gireceğim değerleri controllera gönderiyorum (automatic bind or mapping denebilir)
			// form inputlardaki name sayesinde auto bind oluyor
			User user = new User()
			{
				// classtaki property = formdan gelen value şeklinde
				Username = _user.Username,
				Password = _user.Password,
				FirstName = _user.FirstName,
				LastName = _user.LastName,
				RememberMe = _user.RememberMe
			};

			return View("HtmlHelpers", user); // bu view'a(HtmlHelpers) bu model'i(user) yönlendir
		}

		//// View to Controller
		//[HttpPost] 
		//public IActionResult HtmlHelpers(string Username, string Password, string FirstName, string LastName, bool RememberMe)
		//{
		//          // form'da gireceğim değerleri controllera gönderiyorum (automatic bind or mapping denebilir)
		//          // form inputlardaki name sayesinde auto bind oluyor
		//          User user = new User()
		//          {
		//              // classtaki property = formdan gelen value şeklinde
		//              Username = Username,
		//              Password = Password,
		//              FirstName = FirstName,
		//              LastName = LastName,
		//              RememberMe = RememberMe
		//          };

		//	return View("HtmlHelpers", user); // bu view'a(HtmlHelpers) bu model'i(user) yönlendir
		//}

		//public IActionResult TagHelpers() => View();

		public IActionResult TagHelpers()
		{
			return View();
		}

		[HttpPost]
		public IActionResult TagHelpers(User user)
		{
			return View();
		}
	}
}
