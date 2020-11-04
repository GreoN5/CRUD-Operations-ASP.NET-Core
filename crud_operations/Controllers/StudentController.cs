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
	public class StudentController : Controller
	{
		private StudentContext _studentContext = new StudentContext();
		private List<Student> _students = new List<Student>();

		public IActionResult Index()
		{
			this._students = this._studentContext.Students.ToList();

			return View(this._students);
		}

		[HttpGet]
		public IActionResult AddStudent()
		{
			ViewBag.MajorID = new SelectList(this._studentContext.Majors, "MajorID", "MajorName");

			return View();
		}

		[HttpPost]
		public IActionResult AddStudent(Student student)
		{
			ViewBag.MajorID = new SelectList(this._studentContext.Majors, "MajorID", "MajorName");

			if (ModelState.IsValid)
			{
				this._studentContext.Add(student);
				this._studentContext.SaveChanges();

				return RedirectToAction("Index", "Student");
			}

			return View(student);
		}

		[HttpGet]
		public IActionResult EditStudent(int? id)
		{
			Student student = id == null ? new Student() :
				this._studentContext.Students.Where(s => s.StudentID == id.Value).FirstOrDefault();

			if (student == null)
			{
				return RedirectToAction("Index");
			}

			EditStudentVM item = new EditStudentVM()
			{
				StudentID = student.StudentID,
				FirstName = student.FirstName,
				LastName = student.LastName,
				Gender = student.Gender,
				Year = student.Year,
				MajorID = student.MajorID
			};

			return View(item);
		}

		[HttpPost]
		public IActionResult EditStudent(EditStudentVM model)
		{
			if (!ModelState.IsValid)
			{
				return View(model);
			}

			Student student = new Student()
			{
				StudentID = model.StudentID,
				FirstName = model.FirstName,
				LastName = model.LastName,
				Gender = model.Gender,
				Year = model.Year,
				MajorID = model.MajorID
			};

			if (student.Year != model.Year)
			{
				student.MajorID = model.MajorID;
			}

			this._studentContext.Entry(student).State = EntityState.Modified;

			this._studentContext.SaveChanges();

			return RedirectToAction("Index");
		}

		public IActionResult DeleteStudent(int? id)
		{
			Student student = id == null ? new Student() :
				this._studentContext.Students.Where(s => s.StudentID == id).FirstOrDefault();

			this._studentContext.Entry(student).State = EntityState.Deleted;
			this._studentContext.SaveChanges();

			return RedirectToAction("Index");
		}
	}
}
