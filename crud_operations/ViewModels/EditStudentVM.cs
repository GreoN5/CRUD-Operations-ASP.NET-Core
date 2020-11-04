using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace crud_operations.ViewModels
{
	public class EditStudentVM
	{
		public int StudentID { get; set; }

		[Required(ErrorMessage = "This field is required!")]
		public string FirstName { get; set; }

		[Required(ErrorMessage = "This field is required!")]
		[Display(Name = "Last name")]
		public string LastName { get; set; }

		[Required(ErrorMessage = "This field is required!")]
		public string Gender { get; set; }

		[Display(Name = "Year in university")]
		[Required(ErrorMessage = "This field is required!")]
		public int Year { get; set; }

		public int MajorID { get; set; }
	}
}
