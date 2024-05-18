using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.ViewCommponents.Default
{
    public class _NewslatterPartial:ViewComponent
    {

        public IViewComponentResult Invoke ()
        {
            return View();
        }
    }
}
