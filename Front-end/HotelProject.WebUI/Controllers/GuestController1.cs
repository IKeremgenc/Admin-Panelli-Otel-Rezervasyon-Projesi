using HotelProject.WebUI.Dtos.GuestDto;
using HotelProject.WebUI.Models.Staff;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
  
    public class GuestController1 : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public GuestController1(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:56726/api/Guest");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsondata = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultGuestDto>>(jsondata);
                return View(values);

            }
            return View();

        }
        [HttpGet]
        public ActionResult AddGuestDto()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddGuestDto(CreatGuestDto model)
        {
            if (ModelState.IsValid)
            {
                var client = _httpClientFactory.CreateClient();
                var jshındata = JsonConvert.SerializeObject(model);
                StringContent stringContent = new StringContent(jshındata, Encoding.UTF8, "application/json");
                var responmessage = await client.PostAsync("http://localhost:56726/api/Guest", stringContent);
                if (responmessage.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                return View();
            }
            else
            {
                return View();
            }

        }
        public async Task<IActionResult> DeleteGuest(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"http://localhost:56726/api/Guest/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();

        }
        [HttpGet]
        public async Task<ActionResult> updateGuest(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:56726/api/Guest/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsondata = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateGuestDto>(jsondata);
                return View(values);

            }
            return View();

        }
        [HttpPost]
        public async Task<ActionResult> updateGuest(UpdateGuestDto model)
        {
            if (ModelState.IsValid)
            {
                var client = _httpClientFactory.CreateClient();
                var jsondata = JsonConvert.SerializeObject(model);
                StringContent content = new StringContent(jsondata, Encoding.UTF8, "application/Json");

                var responseMessage = await client.PutAsync("http://localhost:56726/api/Guest", content);
                if (responseMessage.IsSuccessStatusCode)
                {

                    return RedirectToAction("Index");


                }
                return View();
            }
            else
            {
                return View();
            }


        }
    }
}
