using AutoMapper;

using HotelProject.EntityLayer.Concrete;
using HotelsProject.BussinesLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectConsume.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService AboutService)
        {
            _aboutService = AboutService;
        }

        [HttpGet]
        public IActionResult AboutList()
        {
            var values = _aboutService.tGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddAbout(About about)
        {
            _aboutService.tInsert(about);
            return Ok();

        }
        [HttpDelete]
        public IActionResult DeleteAbout(int id)
        {
            var values = _aboutService.tGetByID(id);
            _aboutService.tDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateAbout(About about)
        {
            _aboutService.tUpdate(about);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetAbout(int id)
        {
            var values = _aboutService.tGetByID(id);
            return Ok(values);
        }
    }
}
