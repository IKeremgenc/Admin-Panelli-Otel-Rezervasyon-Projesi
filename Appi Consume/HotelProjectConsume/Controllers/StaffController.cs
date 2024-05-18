 using HotelProject.EntityLayer.Concrete;
using HotelsProject.BussinesLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectConsume.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private  readonly IStaffService _staffService;

        public StaffController(IStaffService staffService)
        {
            _staffService = staffService;
        }

        [HttpGet]
        public IActionResult StaffList()
        { 
            var values=_staffService.tGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddStaff(Staff staff)
        { _staffService.tInsert(staff);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteStaff(int id)
        {
            var values = _staffService.tGetByID(id);
            _staffService.tDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateStaff(Staff staff)
        {
            _staffService.tUpdate(staff);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetStaff(int id)
        {
            var values =_staffService.tGetByID(id);

            return Ok(values);

        }
    }
}
