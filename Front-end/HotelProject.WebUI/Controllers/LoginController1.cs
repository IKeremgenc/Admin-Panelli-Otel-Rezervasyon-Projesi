using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.LoginDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
		[AllowAnonymous]
	public class LoginController1 : Controller
	{
		private readonly SignInManager<AppUser> _signInManager;

		public LoginController1(SignInManager<AppUser> signInManager)
		{
			_signInManager = signInManager;
		}
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public async Task< IActionResult >Index(LoginUserDtocs loginUserDtocs)
		{
			if(ModelState.IsValid)
			{
				var result = await _signInManager.PasswordSignInAsync(loginUserDtocs.UserName, loginUserDtocs.Password,false,false);
				if(result.Succeeded)
				{
					return RedirectToAction("Index", "BookingAdminController1");
				}
				else
				{
					return View();
				}
			}
			return View();
		}
	}
}
