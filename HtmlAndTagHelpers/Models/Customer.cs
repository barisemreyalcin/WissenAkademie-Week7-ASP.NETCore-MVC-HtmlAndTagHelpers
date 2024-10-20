using System.ComponentModel.DataAnnotations;

namespace HtmlAndTagHelpers.Models
{
	public class Customer
	{
		[Display(Name ="Customer Name")]
		public string CustomerId { get; set; }

		[Display(Name = "Company Name")]
		public string CompanyName { get; set; }

		[Display(Name = "Contact Title")]
		public string ContactTitle { get; set; }

		[Display(Name = "Contact Name")]
		public string ContactName { get; set; }

		[Display(Name = "Address")]
		public string Address { get; set; }
	}
}
