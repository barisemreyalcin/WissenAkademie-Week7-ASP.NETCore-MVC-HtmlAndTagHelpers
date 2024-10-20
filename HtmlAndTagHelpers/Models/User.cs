using System.ComponentModel.DataAnnotations;

namespace HtmlAndTagHelpers.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

		[Display(Name = "Last Name")]
		public string LastName { get; set; }

		[Display(Name = "Remember Me")]
		public bool RememberMe { get; set; }
    }
}
