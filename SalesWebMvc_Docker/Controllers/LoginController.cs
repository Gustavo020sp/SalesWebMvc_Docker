using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Data;
using SalesWebMvc.Models;
using SalesWebMvc.Services;
using System.Linq.Expressions;

namespace SalesWebMvc.Controllers
{
	public class LoginController : Controller
	{
		private readonly SalesWebMvcContext _context;

		public LoginController(SalesWebMvcContext context)
		{
			_context = context;
		}
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		[AutoValidateAntiforgeryToken]
		public IActionResult Login(LoginUser loginUser)
		{
			try
			{

				if (ModelState.IsValid)
				{
					var v = _context.LoginUser.Where(a => a.Username.Equals(loginUser.Username) && a.Password.Equals(loginUser.Password)).FirstOrDefault();
					if (v != null)
					{
						return RedirectToAction("Index", "Home");
					}
					TempData["MensagemErro"] = $"Please verify: Username or Password incorret!";
				}
				return View("Index");
			}
			catch (Exception ex)
			{
				return View("Index");
			}
		}
	}
}
