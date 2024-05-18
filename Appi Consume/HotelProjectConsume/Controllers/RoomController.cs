using HotelProject.EntityLayer.Concrete;
using HotelsProject.BussinesLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectConsume.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;

        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        [HttpGet]
        public IActionResult RoomList()
        {
           var values =_roomService.tGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddRoom(Room room)
        {
           _roomService.tInsert(room);
            return Ok();

        }
        [HttpDelete("{id}")]
        public IActionResult DeleteRoom(int id)
        {
          var values =  _roomService.tGetByID(id);
            _roomService.tDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateRoom(Room room)
        {
            _roomService.tUpdate(room);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetRoom(int id)
        {
             var values= _roomService.tGetByID(id);
            return Ok(values);
        }
    }
}
