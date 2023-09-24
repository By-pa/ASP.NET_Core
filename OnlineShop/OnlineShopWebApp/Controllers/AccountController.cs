using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Models;

namespace OnlineShopWebApp.Controllers
{
	public class AccountController : Controller
	{
		public IActionResult Login()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Login(Login login)
		{
			if (ModelState.IsValid)
			{
				return RedirectToAction("Index", "Home");
			}
			return RedirectToAction("Login", "Account");
		}

		public IActionResult Register()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Register(Register register)
		{
			if(register.UserName == register.Password)
			{
				ModelState.AddModelError("", "Логин и пароль не должны совпадать.");
			}

			if (ModelState.IsValid)
			{
				return RedirectToAction("Login", "Account");
			}

			return RedirectToAction("Register", "Account");
		}
	}
}
