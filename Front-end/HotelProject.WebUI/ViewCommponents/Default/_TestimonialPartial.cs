using HotelProject.WebUI.Dtos.ServiceDto;
using HotelProject.WebUI.Dtos.TestimonialDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace HotelProject.WebUI.ViewCommponents.Default
{
    public class _TestimonialPartial : ViewComponent
    {
       
            private readonly IHttpClientFactory _httpClientFactory;

            public _TestimonialPartial(IHttpClientFactory httpClientFactory)
            {
                _httpClientFactory = httpClientFactory;
            }

            public async Task<IViewComponentResult> InvokeAsync()
            {
                var client = _httpClientFactory.CreateClient();
                var responseMessage = await client.GetAsync("http://localhost:56726/api/Testimonial");
                if (responseMessage.IsSuccessStatusCode)
                {
                    var jsondata = await responseMessage.Content.ReadAsStringAsync();
                    var values = JsonConvert.DeserializeObject<List<ResultTestimonial>>(jsondata);
                    return View(values);

                }
                return View();
            }
        }
    }

