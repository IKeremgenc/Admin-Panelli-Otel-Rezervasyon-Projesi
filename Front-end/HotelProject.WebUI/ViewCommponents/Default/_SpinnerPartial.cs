using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.ViewCommponents.Default
{
    public class _SpinnerPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
                return View();
        }
    }
}
