using HotelProject.WebUI.Dtos.BookingDto;
using HotelProject.WebUI.Dtos.ServiceDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
    public class BookingAdminController1 : Controller
    {

        private readonly IHttpClientFactory _httpClientFactory;

        public BookingAdminController1(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:56726/api/Booking");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsondata = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResulBookingDto>>(jsondata);
                return View(values);

            }
            return View();
        }
        public async Task<IActionResult> ApprovedReservation(ApprovedReservationDto reservationDto)
        {
            
            var client = _httpClientFactory.CreateClient();
            var jsondata = JsonConvert.SerializeObject(reservationDto);
            StringContent content = new StringContent(jsondata, Encoding.UTF8, "application/Json");

            var responseMessage = await client.PutAsync("http://localhost:56726/api/Booking/UpdateReservation2", content);
            if (responseMessage.IsSuccessStatusCode)
            {

                return RedirectToAction("Index");


            }
            return View();
        }
    }
}
