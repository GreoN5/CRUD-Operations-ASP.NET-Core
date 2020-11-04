using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace crud_operations.Models
{
	public class Major
	{
		[Key]
		public int MajorID { get; set; }

		[Column(TypeName = "varchar(100)")]
		[Required]
		[Display(Name = "Major")]
		public string MajorName { get; set; }

		[Column(TypeName = "varchar(50)")]
		[Required]
		public string Degree { get; set; }

		public List<Student> Students { get; set; } = new List<Student>();
	}
}
