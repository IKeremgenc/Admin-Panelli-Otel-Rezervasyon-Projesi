using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.ContectDto;
using HotelProject.WebUI.Dtos.SendMessageDto;
using HotelProject.WebUI.Models.Staff;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
    public class AdminContectController1 : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminContectController1(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Inbox()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:56726/api/Contect");

            var client2 = _httpClientFactory.CreateClient();
            var responseMessage2 = await client2.GetAsync("http://localhost:56726/api/Contect/GetCountactCount");

            var client3 = _httpClientFactory.CreateClient();
            var responseMessage3 = await client2.GetAsync("http://localhost:56726/api/SendMessage/SendCountMessage");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsondata = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<InBoxContectDto>>(jsondata);
                var jsondata2 = await responseMessage2.Content.ReadAsStringAsync();

                ViewBag.data = jsondata2;

                var jsondata3 = await responseMessage3.Content.ReadAsStringAsync();

                ViewBag.data2 = jsondata3;

                return View(values);

            }

           
   
         



            return View();

        }

        public async Task<IActionResult> SendBox()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:56726/api/SendMessage");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsondata = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<SendBoxDto>>(jsondata);
                return View(values);

            }
            return View();

        }


        [HttpGet]
        public IActionResult AddSendMessage()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddSendMessage(CreateSendMeesage model)
        {
            model.SenderMail = "info@keremgenc.com";
            model.SenderName = "info@keremgenc.com";
            model.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            var client = _httpClientFactory.CreateClient();
            var jshon = JsonConvert.SerializeObject(model);
            StringContent stringContent = new StringContent(jshon, Encoding.UTF8, "application/json");
            var responsemessage = await client.PostAsync("http://localhost:56726/api/SendMessage", stringContent);
            if (responsemessage.IsSuccessStatusCode)
            {

                return RedirectToAction("AddSendMessage");

            }
            return View();
        }


        public PartialViewResult SidebarAdminContectPartial()
        {
            return PartialView();
        }
        public PartialViewResult SidebarAdminContectCategoryPartial()
        {
            return PartialView();
        }
        public async Task< IActionResult> MessageDetailsBySendBox(int id)
        {

            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:56726/api/SendMessage/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsondata = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<GetMessageByidDto>(jsondata);
                return View(values);

            }
            return View();

        }

        public async Task<IActionResult> MessageDetailsByInbox(int id)
        {

            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:56726/api/Contect/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsondata = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<InBoxContectDto>(jsondata);
                return View(values);

            }
            return View();

        }


    }
}
