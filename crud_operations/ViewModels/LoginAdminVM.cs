using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace crud_operations.ViewModels
{
	public class LoginAdminVM
	{
		[Required(ErrorMessage = "This field is required!")]
		public string Username { get; set; }

		[Required(ErrorMessage = "This field is required!")]
		public string Password { get; set; }
	}
}
