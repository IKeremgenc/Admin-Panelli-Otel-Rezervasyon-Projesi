using HotelProject.EntityLayer.Concrete;
using HotelsProject.BussinesLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectConsume.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpGet]
        public IActionResult BookingList()
        {
            var values = _bookingService.tGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddBooking(Booking booking)
        {
            _bookingService.tInsert(booking);
            return Ok();

        }
        [HttpDelete]
        public IActionResult DeletBooking(int id)
        {
            var values = _bookingService.tGetByID(id);
            _bookingService.tDelete(values);
            return Ok();
        }
        [HttpPut("UpdateBooking")]
        public IActionResult UpdateBooking(Booking booking)
        {
            _bookingService.tUpdate(booking);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetAbout(int id)
        {
            var values = _bookingService.tGetByID(id);
            return Ok(values);
        }
        [HttpPut("UpdateReservation")]
        public IActionResult UpdateReservation(Booking booking)
        {
            _bookingService.BookingStatusChangeApprode(booking);
            return Ok();
        }
        [HttpPut("UpdateReservation2")]
        public IActionResult UpdateReservation2(int id)
        {
            _bookingService.BookingStatusChangeApprode2(id);
            return Ok();
        }
    }
}

