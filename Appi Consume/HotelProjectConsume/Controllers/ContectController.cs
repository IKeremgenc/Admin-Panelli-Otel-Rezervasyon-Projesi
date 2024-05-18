using HotelProject.EntityLayer.Concrete;
using HotelsProject.BussinesLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace HotelProjectConsume.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContectController : ControllerBase
    {
        private readonly IContectService _contectService;

        public ContectController(IContectService contectService)
        {
            _contectService = contectService;
        }
        [HttpPost]
        public IActionResult AddContect(Contect contect)
        {
            contect.Date = Convert.ToDateTime(DateTime.Now.ToString());
            _contectService.tInsert(contect);
            return Ok();

        }
        [HttpGet]
        public IActionResult ContectInboxList()
        {
            var values = _contectService.tGetList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetSendMessage(int id)
        {
            var values = _contectService.tGetByID(id);

            return Ok(values);

        }
        [HttpGet("GetCountactCount")]
        public IActionResult GetCountectCount()
        {
            return Ok(_contectService.TGetCountactCount());
        }
    }
}
