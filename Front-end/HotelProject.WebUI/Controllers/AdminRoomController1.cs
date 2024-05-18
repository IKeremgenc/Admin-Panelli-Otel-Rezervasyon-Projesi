using HotelProject.WebUI.Dtos.RoomDto;
using HotelProject.WebUI.Models.Staff;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
    public class AdminRoomController1 : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminRoomController1(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:56726/api/Room");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsondata = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultRoomDto>>(jsondata);
                return View(values);

            }
            return View();

        }
        [HttpGet]
        public ActionResult AddRoom()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddRoom(CreatRoomdto model)
        {
            var client = _httpClientFactory.CreateClient();
            var jshındata = JsonConvert.SerializeObject(model);
            StringContent stringContent = new StringContent(jshındata, Encoding.UTF8, "application/json");
            var responmessage = await client.PostAsync("http://localhost:56726/api/Room", stringContent);
            if (responmessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        public async Task<IActionResult> DeleteRoom(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"http://localhost:56726/api/Room/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();

        }
        [HttpGet]
        public async Task<ActionResult> updateRoom(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:56726/api/Room/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsondata = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<updateroomDto>(jsondata);
                return View(values);

            }
            return View();

        }
        [HttpPost]
        public async Task<ActionResult> updateRoom(updateroomDto model)
        {
            var client = _httpClientFactory.CreateClient();
            var jsondata = JsonConvert.SerializeObject(model);
            StringContent content = new StringContent(jsondata, Encoding.UTF8, "application/Json");

            var responseMessage = await client.PutAsync("http://localhost:56726/api/Room", content);
            if (responseMessage.IsSuccessStatusCode)
            {

                return RedirectToAction("Index");


            }
            return View();

        }
    }
}
