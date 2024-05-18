using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Collections.Generic;
using RapidApiConsume.Models;
using Newtonsoft.Json;
using System.Linq;

namespace RapidApiConsume.Controllers
{
    public class ExChangController1 : Controller
    {
        public async Task< IActionResult >Index()
        {
          
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://booking-com.p.rapidapi.com/v1/metadata/exchange-rates?currency=TRY&locale=en-gb"),
                Headers =
    {
        { "X-RapidAPI-Key", "168198f5ffmshdd1184605cea6dcp176eafjsn4896960db826" },
        { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ExChangeViewModel>(body);
               
            return View(values.exchange_rates.ToList());
            }
        }
    }
}
