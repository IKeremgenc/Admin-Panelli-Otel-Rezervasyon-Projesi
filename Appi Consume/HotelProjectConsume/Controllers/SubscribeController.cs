using HotelProject.EntityLayer.Concrete;
using HotelsProject.BussinesLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectConsume.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribeController : ControllerBase
    {

        private readonly ISubscribeService _subscribeService;

        public SubscribeController(ISubscribeService subscribeService)
        {
            _subscribeService = subscribeService;
        }

        [HttpGet]
        public IActionResult SubscribeList()
        {
            var values = _subscribeService.tGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddSubscribe(Subscribe Subscribe)
        {
            _subscribeService.tInsert(Subscribe);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteSubscribe(int id)
        {
            var values = _subscribeService.tGetByID(id);
            _subscribeService.tDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateSubscribe(Subscribe Subscribe)
        {
            _subscribeService.tUpdate(Subscribe);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetSubscribe(int id)
        {
            var values = _subscribeService.tGetByID(id);

            return Ok(values);
        }
    }
}
