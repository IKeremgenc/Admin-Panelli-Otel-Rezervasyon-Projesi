using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.ViewCommponents.Default
{
    public class _TrailerPartial:ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
