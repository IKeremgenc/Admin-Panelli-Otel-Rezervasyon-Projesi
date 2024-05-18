using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.AppUserDto;
using HotelProject.WebUI.Dtos.RoomDto;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit.Cryptography;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
	public class AdminUserController1 : Controller
	{

    

        private readonly IHttpClientFactory _httpClientFactory;

        public AdminUserController1(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            //var client = _httpClientFactory.CreateClient();
            //var responseMessage = await client.GetAsync("http://localhost:56726/api/AppUser");
            //if (responseMessage.IsSuccessStatusCode)
            //{
            //    var jsondata = await responseMessage.Content.ReadAsStringAsync();
            //    var values = JsonConvert.DeserializeObject<List<ResulAppUserDto>>(jsondata);
            //    return View(values);

            //}
            return View();

        }
        public  async Task<IActionResult> UserList()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:56726/api/AppUser");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsondata = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultAppUserWokrLocationDto>>(jsondata);
                return View(values);

            }
            return View();

        }


    }
}
