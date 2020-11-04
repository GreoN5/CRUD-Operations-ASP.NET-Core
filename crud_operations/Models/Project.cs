using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace crud_operations.Models
{
	public class Project
	{
		[Key]
		public int ProjectID { get; set; }

		[Column(TypeName = "varchar(100)")]
		[Required]
		[Display(Name = "Project name")]
		public string ProjectName { get; set; }

		public virtual List<ProjectToStudent> ProjectToStudents { get; set; } = new List<ProjectToStudent>();
	}
}
