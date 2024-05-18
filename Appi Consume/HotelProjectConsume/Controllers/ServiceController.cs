using HotelProject.EntityLayer.Concrete;
using HotelsProject.BussinesLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectConsume.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceServices _services;

        public ServiceController(IServiceServices services)
        {
            _services = services;
        }

        [HttpGet]
        public IActionResult ServiceList()
        {
            var values = _services.tGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddService(Services Service)
        {
            _services.tInsert(Service);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteService(int id)
        {
            var values = _services.tGetByID(id);
            _services.tDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateService(Services Service)
        {
            _services.tUpdate(Service);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetService(int id)
        {
            var values = _services.tGetByID(id);

            return Ok(values);
        }
    }
}
