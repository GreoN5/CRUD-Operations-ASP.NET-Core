using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace crud_operations.Models
{
	public class ProjectToStudent
	{
		[Column(Order = 1)]
		public int ProjectID { get; set; }

		[Column(Order = 2)]
		public int StudentID { get; set; }

		public virtual Student Student { get; set; }
		public virtual Project Project { get; set; }
	}
}
