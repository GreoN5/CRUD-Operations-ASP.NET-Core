using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using crud_operations.ActionFilters;
using crud_operations.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace crud_operations.Controllers
{
	[Auth]
	public class ProjectController : Controller
	{
		private StudentContext _studentContext = new StudentContext();
		private List<Project> _projects = new List<Project>();
		private List<Student> _students = new List<Student>();
		private List<ProjectToStudent> _projectsToStudents = new List<ProjectToStudent>();

		public IActionResult Index()
		{
			this._projects = this._studentContext.Projects.ToList();

			return View(this._projects);
		}

		public IActionResult ProjectsToStudents()
		{
			this._projectsToStudents = this._studentContext.ProjectsToStudents.ToList();

			return View(this._projectsToStudents);
		}

		[HttpGet]
		public IActionResult CreateNewProject()
		{
			return View();
		}

		[HttpPost]
		public IActionResult CreateNewProject(Project project)
		{
			if (ModelState.IsValid)
			{
				this._studentContext.Add(project);
				this._studentContext.SaveChanges();

				return RedirectToAction("Index", "Project");
			}

			return View();
		}

		[HttpGet]
		public IActionResult CreateNewInstance()
		{
			ViewBag.ProjectID = new SelectList(this._studentContext.Projects, "ProjectID", "ProjectName");
			ViewBag.StudentID = new SelectList(this._studentContext.Students, "StudentID", "StudentID");

			return View();
		}

		[HttpPost]
		public IActionResult CreateNewInstance(ProjectToStudent projectToStudent)
		{
			if (ModelState.IsValid)
			{
				this._studentContext.Add(projectToStudent);
				this._studentContext.SaveChanges();

				return RedirectToAction("ProjectsToStudents", "Project");
			}

			return View();
		}
	}
}
