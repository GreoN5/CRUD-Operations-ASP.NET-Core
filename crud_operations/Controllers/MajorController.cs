using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using crud_operations.ActionFilters;
using crud_operations.Models;
using crud_operations.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace crud_operations.Controllers
{
	[Auth]
	public class MajorController : Controller
	{
		private StudentContext _studentContext = new StudentContext();
		private List<Major> _majors = new List<Major>();
		private List<Student> _students = new List<Student>();

		public IActionResult Index()
		{
			this._majors = this._studentContext.Majors.ToList();

			return View(this._majors);
		}

		[HttpGet]
		public IActionResult AddMajor()
		{
			return View();
		}

		[HttpPost]
		public IActionResult AddMajor(Major major)
		{
			if (ModelState.IsValid)
			{
				this._studentContext.Add(major);
				this._studentContext.SaveChanges();

				return RedirectToAction("Index", "Major");
			}

			return View(major);
		}

		public IActionResult Students(int id)
		{
			this._students = this._studentContext.Students.Where(s => s.MajorID == id).ToList();

			return View(this._students);
		}

		[HttpGet]
		public IActionResult AddStudentToMajor()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult AddStudentToMajor(int? id, Student student)
		{
			Major major = id == null ? new Major() :
				   this._studentContext.Majors.Where(m => m.MajorID == id).FirstOrDefault();

			if (major == null)
			{
				return RedirectToAction("Index");
			}
			else
			{
				student.MajorID = major.MajorID;
			}

			if (ModelState.IsValid)
			{
				this._studentContext.Add(student);
				this._studentContext.SaveChanges();

				return RedirectToAction("Index", "Major");
			}

			return View(student);
		}
	}
}
