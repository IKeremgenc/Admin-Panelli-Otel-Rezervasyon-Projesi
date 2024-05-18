using HotelProject.EntityLayer.Concrete;
using HotelsProject.BussinesLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectConsume.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkLocationController : ControllerBase
    {
        private readonly IWorkLocationService _workLocationService;

        public WorkLocationController(IWorkLocationService workLocationService)
        {
            _workLocationService = workLocationService;
        }

        [HttpGet]
        public IActionResult WorkLocationList()
        {
            var values = _workLocationService.tGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddWorkLocation(WorkLocation WorkLocation)
        {
            _workLocationService.tInsert(WorkLocation);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteWorkLocation(int id)
        {
            var values = _workLocationService.tGetByID(id);
            _workLocationService.tDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateWorkLocation(WorkLocation WorkLocation)
        {
            _workLocationService.tUpdate(WorkLocation);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetWorkLocation(int id)
        {
            var values = _workLocationService.tGetByID(id);

            return Ok(values);

        }
    }
}
