using HotelProject.EntityLayer.Concrete;
using HotelsProject.BussinesLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectConsume.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly  ITestimonailService _estimonailService;


       
        public TestimonialController(ITestimonailService estimonailService)
        {
            _estimonailService = estimonailService;
        }

        [HttpGet]
        public IActionResult TestimonialList()
        {
            var values = _estimonailService.tGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddTestimonial(Testimonial Testimonial)
        {
            _estimonailService.tInsert(Testimonial);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteTestimonial(int id)
        {
            var values = _estimonailService.tGetByID(id);
            _estimonailService.tDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateTestimonial(Testimonial Testimonial)
        {
            _estimonailService.tUpdate(Testimonial);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetTestimonial(int id)
        {
            var values = _estimonailService.tGetByID(id);

            return Ok(values);
        }
    }
}
