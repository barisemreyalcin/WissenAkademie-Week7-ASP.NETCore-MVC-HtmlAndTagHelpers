using HtmlAndTagHelpers.Models;
using Microsoft.AspNetCore.Mvc;

namespace HtmlAndTagHelpers.Controllers
{
	public class CustomerController : Controller
	{
		public List<Customer> customers = new List<Customer>()
		{
			new Customer(){CustomerId = "ALFKI", CompanyName = "Alison Company", ContactTitle = "Sales Manager", ContactName = "John Doe", Address = "Utah, USA" },
			new Customer(){CustomerId = "VINET", CompanyName = "Vincent Company", ContactTitle = "Owner", ContactName = "Vincent Doe", Address = "New Jersey, USA" },
			new Customer(){CustomerId = "BEYCO", CompanyName = "BEY Company", ContactTitle = "Owner", ContactName = "Barış Emre Yalçın", Address = "Los Angeles, USA" },
			new Customer(){CustomerId = "JSCOM", CompanyName = "JS Company", ContactTitle = "IT Manager", ContactName = "Java Script", Address = "Arizona, USA" }
		};
		public IActionResult Index()
		{
			return View(customers);
		}

		public IActionResult CustomerDetail(string id)
		{
			Customer customer = customers.FirstOrDefault(x => x.CustomerId == id);
			return View(customer);
		}

		public IActionResult CustomerEdit(string id)
		{
			Customer customer = customers.FirstOrDefault(x => x.CustomerId == id);
			return View(customer);
		}

		public IActionResult CustomerDelete(string id)
		{
			Customer customer = customers.FirstOrDefault(x => x.CustomerId == id);
			return View(customer);
		}
	}
}
