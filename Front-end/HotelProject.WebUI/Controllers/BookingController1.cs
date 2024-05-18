using HotelProject.WebUI.Dtos.BookingDto;
using HotelProject.WebUI.Dtos.NewsLatterResultDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
    [AllowAnonymous]
    public class BookingController1 : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BookingController1(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddBooking()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult > AddBooking(CreatBookingDto creatBookingDto)
        {
            creatBookingDto.Statues = "Onay Bekliyor";
            var client = _httpClientFactory.CreateClient();
            var jshındata = JsonConvert.SerializeObject(creatBookingDto);
            StringContent stringContent = new StringContent(jshındata, Encoding.UTF8, "application/json");
            var responmessage = await client.PostAsync("http://localhost:56726/api/Booking", stringContent);

            return RedirectToAction("Index", "DefaultController1");
         
        }
    }
}
