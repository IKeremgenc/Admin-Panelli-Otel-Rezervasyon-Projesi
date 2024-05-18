using HotelProject.WebUI.Dtos.BookingDto;
using HotelProject.WebUI.Dtos.ContectDto;
using HotelProject.WebUI.Dtos.rESULTcATEGORYmESSAGE;
using HotelProject.WebUI.Models.Staff;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
	[AllowAnonymous]
	public class ContectController1 : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public ContectController1(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}
		public async Task<IActionResult> Index()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("http://localhost:56726/api/CategoryMessage");

			var jsondata = await responseMessage.Content.ReadAsStringAsync();
			var values = JsonConvert.DeserializeObject<List<ResultCategoryMessage>>(jsondata);

			List<SelectListItem> values2 = (from x in values
											select new SelectListItem
											{
												Text = x.MessageName,
												Value = x.MessageCategorid.ToString()
											}).ToList();

			ViewBag.v = values2;

			return View();



		}
		[HttpGet]
		public PartialViewResult SendMessage()
		{
			return PartialView();
		}
		[HttpPost]
		public async Task<IActionResult> SendMessage(CreatContectDto creatContectDto)
		{
			creatContectDto.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
			var client = _httpClientFactory.CreateClient();
			var jshındata = JsonConvert.SerializeObject(creatContectDto);
			StringContent stringContent = new StringContent(jshındata, Encoding.UTF8, "application/json");
			var responmessage = await client.PostAsync("http://localhost:56726/api/Contect", stringContent);

			return RedirectToAction("Index", "DefaultController1");

		}
	}
}
