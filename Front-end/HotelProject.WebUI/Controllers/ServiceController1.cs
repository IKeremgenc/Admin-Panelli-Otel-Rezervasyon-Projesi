using HotelProject.WebUI.Dtos.ServiceDto;
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
   
    public class ServiceController1 : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ServiceController1(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:56726/api/Service");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsondata = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultServiceDto>>(jsondata);
                return View(values);

            }
            return View();
        }
        [HttpGet]
        public ActionResult AddService()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddService(CreatServiceDto serviceDto)
        {
            if (!ModelState.IsValid)
            {
                return View();  

            }
            var client = _httpClientFactory.CreateClient();
            var jshındata = JsonConvert.SerializeObject(serviceDto);
            StringContent stringContent = new StringContent(jshındata, Encoding.UTF8, "application/json");
            var responmessage = await client.PostAsync("http://localhost:56726/api/Service", stringContent);
            if (responmessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        public  async Task<IActionResult> DeleteService(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responemessage = await client.DeleteAsync($"http://localhost:56726/api/Service/{id}");
            if (responemessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");

            }
            return View();

        }
        [HttpGet]
        public async Task<ActionResult> updateService(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:56726/api/Service/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsondata = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateServiceDto>(jsondata);
                return View(values);

            }
            return View();

        }
        [HttpPost]
        public async Task<ActionResult> updateService(UpdateServiceDto serviceDto)
        {
            if (!ModelState.IsValid)
            {
                return View();

            }
            var client = _httpClientFactory.CreateClient();
            var jsondata = JsonConvert.SerializeObject(serviceDto);
            StringContent content = new StringContent(jsondata, Encoding.UTF8, "application/Json");

            var responseMessage = await client.PutAsync("http://localhost:56726/api/Service", content);
            if (responseMessage.IsSuccessStatusCode)
            {

                return RedirectToAction("Index");


            }
            return View();

        }
    }
}
