using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.ViewCommponents.Default
{
    public class _HeadPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
