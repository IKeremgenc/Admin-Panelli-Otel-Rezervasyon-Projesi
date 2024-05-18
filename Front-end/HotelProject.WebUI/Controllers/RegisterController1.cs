using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.RegisterDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
    [AllowAnonymous]
    public class RegisterController1 : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController1(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(CreatNewUserDto creatNewUserDto)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var appuser = new AppUser()
            {
                Name =  creatNewUserDto.Name,
                SurName = creatNewUserDto.SurName,
                Email = creatNewUserDto.Mail,
                UserName = creatNewUserDto.UserName,
                WorkLocationid= 1


            };
            var result = await _userManager.CreateAsync(appuser, creatNewUserDto.Sifre);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "LoginController1");
            }


            return View();
        }
    }
}
