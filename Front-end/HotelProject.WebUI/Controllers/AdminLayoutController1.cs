using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers
{
    public class AdminLayoutController1 : Controller
    {
        public IActionResult _AdmniLayout()
        {
            return View();
        }

        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }
        public PartialViewResult ScriptPartial()
        {
            return PartialView();
        }
        public PartialViewResult SideBarPartial()
        {
            return PartialView();
        }
        public PartialViewResult HeaderBarPartial()
        {
            return PartialView();
        }
    }
}
