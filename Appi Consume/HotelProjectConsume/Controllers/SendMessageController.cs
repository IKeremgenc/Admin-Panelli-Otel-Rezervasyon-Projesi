using HotelProject.EntityLayer.Concrete;
using HotelsProject.BussinesLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectConsume.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SendMessageController : ControllerBase
    {
        private readonly ISenderMessageService _senderMessageService;

        public SendMessageController(ISenderMessageService senderMessageService)
        {
            _senderMessageService = senderMessageService;
        }

        [HttpGet]
        public IActionResult SendMessageList()
        {
            var values = _senderMessageService.tGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddSendMessage( SendMessage sendMessage)
        {
            _senderMessageService.tInsert(sendMessage);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteSendMessage(int id)
        {
            var values = _senderMessageService.tGetByID(id);
            _senderMessageService.tDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateSendMessage(SendMessage SendMessage)
        {
            _senderMessageService.tUpdate(SendMessage);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetSendMessage(int id)
        {
            var values = _senderMessageService.tGetByID(id);

            return Ok(values);

        }

        [HttpGet("SendCountMessage")]
        public IActionResult SendCountMessage()
        {
            return Ok ( _senderMessageService.TSendCountMessage());
        }

    }
}
