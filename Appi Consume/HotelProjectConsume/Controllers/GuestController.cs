using HotelProject.DataAccsesLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using HotelsProject.BussinesLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectConsume.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestController : ControllerBase
    {
        private readonly IGuestServie _guestServiece;

        public GuestController(IGuestServie guestServie)
        {
            _guestServiece = guestServie;
        }

        [HttpGet]
        public IActionResult GuestList()
        {
            var values = _guestServiece.tGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddGuest(Guest guest)
        {
            _guestServiece.tInsert(guest);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteGuest(int id)
        {
            var values = _guestServiece.tGetByID(id);
            _guestServiece.tDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateGuest(Guest guest)
        {
            _guestServiece.tUpdate(guest);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetGuest(int id)
        {
            var values = _guestServiece.tGetByID(id);

            return Ok(values);

        }
    }
}
