using HotelProject.WebUI.Dtos.NewsLatterResultDto;
using HotelProject.WebUI.Dtos.StaffDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
    [AllowAnonymous]
    public class DefaultController1 : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DefaultController1(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult NewsLatterResult()
        {
            return PartialView();
        }

        [HttpPost]
        public async Task<IActionResult > NewsLatterResult(CreatSubscribeDto creatSubscribeDto)
        {
            
            var client = _httpClientFactory.CreateClient();
            var jshındata = JsonConvert.SerializeObject(creatSubscribeDto);
            StringContent stringContent = new StringContent(jshındata, Encoding.UTF8, "application/json");
            var responmessage = await client.PostAsync("http://localhost:56726/api/Subscribe", stringContent);
           
                return RedirectToAction("Index", "DefaultController1");
           

        
        }
    }
}
