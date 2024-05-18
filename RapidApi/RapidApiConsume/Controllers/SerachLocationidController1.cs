using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using RapidApiConsume.Models;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;

namespace RapidApiConsume.Controllers
{
    public class SerachLocationidController1 : Controller
    {
        public async Task< IActionResult >Index(string cityname)
        {
            if (!string.IsNullOrEmpty(cityname))
            {
                List<BookingApiLocationSerchViewvModel> bookingApiLocationSerchViewvModels = new List<BookingApiLocationSerchViewvModel>();

                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v1/hotels/locations?name={cityname}&locale=en-gb"),
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
                    bookingApiLocationSerchViewvModels = JsonConvert.DeserializeObject<List<BookingApiLocationSerchViewvModel>>(body);
                    return View(bookingApiLocationSerchViewvModels.Take(1).ToList());
                }
            }
            else
            {
                List<BookingApiLocationSerchViewvModel> bookingApiLocationSerchViewvModels = new List<BookingApiLocationSerchViewvModel>();

                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://booking-com.p.rapidapi.com/v1/hotels/locations?name=paris&locale=en-gb"),
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
                    bookingApiLocationSerchViewvModels = JsonConvert.DeserializeObject<List<BookingApiLocationSerchViewvModel>>(body);
                    return View(bookingApiLocationSerchViewvModels.Take(1).ToList());
                }
            }
           
        }

    }
}
