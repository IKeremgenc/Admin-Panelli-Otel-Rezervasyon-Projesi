using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.ViewCommponents.Booking
{
    public class _BookingCoverPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
