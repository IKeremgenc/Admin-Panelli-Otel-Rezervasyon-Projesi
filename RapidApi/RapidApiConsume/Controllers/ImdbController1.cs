using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Collections.Generic;
using RapidApiConsume.Models;
using Newtonsoft.Json;

namespace RapidApiConsume.Controllers
{
    public class ImdbController1 : Controller
    {
        public async Task< IActionResult >Index()
        {
            List<ImdbViewModel> ımdbViewModels = new List<ImdbViewModel>();
           
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://imdb-top-100-movies1.p.rapidapi.com/"),
                Headers =
    {
        { "X-RapidAPI-Key", "168198f5ffmshdd1184605cea6dcp176eafjsn4896960db826" },
        { "X-RapidAPI-Host", "imdb-top-100-movies1.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                ımdbViewModels=JsonConvert.DeserializeObject<List<ImdbViewModel>>(body);
                return View(ımdbViewModels);
                
            }
            
        }
    }
}
