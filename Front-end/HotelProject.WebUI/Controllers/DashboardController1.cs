using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers
{
    public class DashboardController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
