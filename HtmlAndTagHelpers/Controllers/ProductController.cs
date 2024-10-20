using HtmlAndTagHelpers.Models;
using Microsoft.AspNetCore.Mvc;

namespace HtmlAndTagHelpers.Controllers
{
	public class ProductController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult HelpersForProducts()
		{
			return View();
		}

		[HttpPost]
		public IActionResult HelpersForProducts(Product _product)
		{
			Product product = new Product()
			{
				ProductName = _product.ProductName,
				Price = _product.Price,
				Quantity = _product.Quantity,
				Category = _product.Category,
			};
			return View();
		}
	}
}
