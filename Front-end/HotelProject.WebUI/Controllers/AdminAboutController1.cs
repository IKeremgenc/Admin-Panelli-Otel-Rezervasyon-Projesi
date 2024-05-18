using HotelProject.WebUI.Dtos.AboutDto;
using HotelProject.WebUI.Dtos.BookingDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
    public class AdminAboutController1 : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminAboutController1(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:56726/api/About");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsondata = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultAboutDto>>(jsondata);
                return View(values);

            }
            return View();
        }
        [HttpGet]
        public async Task<ActionResult> UpdateAbout(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:56726/api/About/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsondata = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateAboutDto>(jsondata);
                return View(values);

            }
            return View();

        }
        [HttpPost]
        public async Task<ActionResult> UpdateAbout(UpdateAboutDto model)
        {
            var client = _httpClientFactory.CreateClient();
            var jsondata = JsonConvert.SerializeObject(model);
            StringContent content = new StringContent(jsondata, Encoding.UTF8, "application/Json");

            var responseMessage = await client.PutAsync("http://localhost:56726/api/About", content);
            if (responseMessage.IsSuccessStatusCode)
            {

                return RedirectToAction("Index");


            }
            return View();

        }
    }
}
