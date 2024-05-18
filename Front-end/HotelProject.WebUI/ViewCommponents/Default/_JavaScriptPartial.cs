using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.ViewCommponents.Default
{
    public class _JavaScriptPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
