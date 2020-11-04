using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using crud_operations.Models;
using crud_operations.Tools;
using crud_operations.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace crud_operations.Controllers
{
	public class HomeController : Controller
	{
		private StudentContext _studentContext = new StudentContext();

		public IActionResult Index()
		{
			return View();
		}

		[HttpGet]
		public IActionResult Login()
		{
			LoginAdminVM admin = new LoginAdminVM();

			return View(admin);
		}

		public IActionResult Login([FromForm] LoginAdminVM login)
		{
			if (ModelState.IsValid)
			{
				Admin admin = this._studentContext.Admins.Where(a => a.Username == login.Username && a.Password == login.Password)
					.FirstOrDefault();

				this.HttpContext.Session.SetObject("admin", admin);
			}

			if (this.HttpContext.Session.GetObject<Admin>("admin") == null)
			{
				return View(login);
			}

			return RedirectToAction("Index");
		}

		public IActionResult Logout()
		{
			HttpContext.Session.Remove("admin");

			return RedirectToAction("Index");
		}
	}
}
