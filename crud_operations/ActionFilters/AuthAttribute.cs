using crud_operations.Models;
using crud_operations.Tools;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crud_operations.ActionFilters
{
	public class AuthAttribute : ActionFilterAttribute
	{
		public override void OnActionExecuting(ActionExecutingContext context)
		{
			if (context.HttpContext.Session.GetObject<Admin>("admin") == null)
				context.Result = new RedirectResult("/Home/Login");
		}
	}
}
