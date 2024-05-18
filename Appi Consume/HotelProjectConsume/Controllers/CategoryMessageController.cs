using HotelProject.EntityLayer.Concrete;
using HotelsProject.BussinesLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectConsume.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CategoryMessageController : ControllerBase
	{
		private readonly ICategorMessageService _categorMessageService;

		public CategoryMessageController(ICategorMessageService categorMessage)
		{
			_categorMessageService = categorMessage;
		}
	
		[HttpGet]
		public IActionResult CategoreMessageList()
		{
			var values = _categorMessageService.tGetList();
			return Ok(values);
		}
		[HttpPost]
		public IActionResult AddCategoreMessage(CategoreMessage CategoreMessage)
		{
			_categorMessageService.tInsert(CategoreMessage);
			return Ok();
		}
		[HttpDelete("{id}")]
		public IActionResult DeleteCategoreMessage(int id)
		{
			var values = _categorMessageService.tGetByID(id);
			_categorMessageService.tDelete(values);
			return Ok();
		}
		[HttpPut]
		public IActionResult UpdateCategoreMessage(CategoreMessage CategoreMessage)
		{
			_categorMessageService.tUpdate(CategoreMessage);
			return Ok();
		}
		[HttpGet("{id}")]
		public IActionResult GetCategoreMessage(int id)
		{
			var values = _categorMessageService.tGetByID(id);

			return Ok(values);

		}


	}
}
