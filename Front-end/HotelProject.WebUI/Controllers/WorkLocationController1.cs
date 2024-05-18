using HotelProject.WebUI.Dtos.AboutDto;
using HotelProject.WebUI.Dtos.WorkLocationDto;
using HotelProject.WebUI.Models.Staff;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
    public class WorkLocationController1 : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public WorkLocationController1(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:56726/api/WorkLocation");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsondata = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResulcWorkLocationDto>>(jsondata);
                return View(values);

            }
            return View();
        }

        [HttpGet]
        public ActionResult AddWorkLocation()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddWorkLocation(AddWorkLocationDto model)
        {
            var client = _httpClientFactory.CreateClient();
            var jshındata = JsonConvert.SerializeObject(model);
            StringContent stringContent = new StringContent(jshındata, Encoding.UTF8, "application/json");
            var responmessage = await client.PostAsync("http://localhost:56726/api/WorkLocation", stringContent);
            if (responmessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }


        [HttpGet]
        public async Task<ActionResult> UpdateWorkLocation(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:56726/api/WorkLocation/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsondata = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateResultWorkLocationDto>(jsondata);
                return View(values);

            }
            return View();

        }
        [HttpPost]
        public async Task<ActionResult> UpdateWorkLocation(UpdateResultWorkLocationDto model)
        {
            var client = _httpClientFactory.CreateClient();
            var jsondata = JsonConvert.SerializeObject(model);
            StringContent content = new StringContent(jsondata, Encoding.UTF8, "application/Json");

            var responseMessage = await client.PutAsync("http://localhost:56726/api/WorkLocation", content);
            if (responseMessage.IsSuccessStatusCode)
            {

                return RedirectToAction("Index");


            }
            return View();

        }
        public async Task<IActionResult> DeleteStaff(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"http://localhost:56726/api/WorkLocation/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();

        }
    }
}
