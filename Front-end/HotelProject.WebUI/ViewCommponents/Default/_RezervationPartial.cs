using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.ViewCommponents.Default
{
    public class _RezervationPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
