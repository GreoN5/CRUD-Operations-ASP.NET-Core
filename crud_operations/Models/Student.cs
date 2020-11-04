using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace crud_operations.Models
{
	public class Student
	{
		[Key]
		public int StudentID { get; set; }

		[Column(TypeName = "varchar(50)")]
		[Required]
		[Display(Name = "First name")]
		public string FirstName { get; set; }

		[Column(TypeName = "varchar(50)")]
		[Required]
		[Display(Name = "Last name")]
		public string LastName { get; set; }

		[Column(TypeName = "char(1)")]
		[RegularExpression("[MF]", ErrorMessage = ("The gender must be either \"M\" for male or \"F\" for female!"))]
		[Required]
		public string Gender { get; set; }

		[Column(TypeName = "int")]
		[Required]
		[Range(1, 5, ErrorMessage = ("The year must be 1-4 for Bachelor's or 5 for Master's degrees!"))]
		[Display(Name = "Year in university")]
		public int Year { get; set; }

		[ForeignKey("Majors")]
		public int MajorID { get; set; }

		public virtual Major Major { get; set; }
		public virtual List<ProjectToStudent> ProjectToStudents { get; set; } = new List<ProjectToStudent>();
	}
}
