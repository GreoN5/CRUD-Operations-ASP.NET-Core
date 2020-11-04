using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crud_operations.Models
{
	public class StudentContext : DbContext
	{
		public DbSet<Student> Students { get; set; }
		public DbSet<Major> Majors { get; set; }
		public DbSet<Project> Projects { get; set; }
		public DbSet<ProjectToStudent> ProjectsToStudents { get; set; }
		public DbSet<Admin> Admins { get; set; }

		public StudentContext() : base() { }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=DESKTOP-OI3QR52\\SQLEXPRESS;Database=University;Trusted_Connection=True;MultipleActiveResultSets=True;");
		}

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.Entity<ProjectToStudent>().HasKey(ps => new { ps.ProjectID, ps.StudentID });
		}
	}
}
