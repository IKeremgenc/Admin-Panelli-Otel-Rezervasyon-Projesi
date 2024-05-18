using HotelProject.WebUI.Dtos.AppUserDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
    public class AdminWithLocations2Controller : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminWithLocations2Controller(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> UserList()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:56726/api/AppUserLocation");
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
