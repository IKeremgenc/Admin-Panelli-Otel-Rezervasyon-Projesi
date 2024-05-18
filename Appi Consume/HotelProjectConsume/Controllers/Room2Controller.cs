using AutoMapper;
using HotelProject.DtoLayer.Dtos.RoomDto;
using HotelProject.EntityLayer.Concrete;
using HotelsProject.BussinesLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HotelProjectConsume.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Room2Controller : ControllerBase
    {
        private readonly IRoomService _roomService;
        private readonly IMapper _mapper;



        public Room2Controller(IRoomService roomService, IMapper mapper)
        {
            _roomService = roomService;
            _mapper = mapper;
        }


        [HttpGet]
        public IActionResult Index()
        {
            var values = _roomService.tGetList();
            return Ok(values);

        }
        [HttpPost]
        public IActionResult AddRoom(RoomAdDto roomAdDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();  
            }
            var values = _mapper.Map<Room>(roomAdDto);
            _roomService.tInsert(values);
         
            return Ok();



        }
        [HttpPut]
        public IActionResult UpdateRoom(UpdateRoomDto roomDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Room>(roomDto);
            _roomService.tUpdate(values);
            return Ok("Başrıyla güncellendi");
        }
    }
}
