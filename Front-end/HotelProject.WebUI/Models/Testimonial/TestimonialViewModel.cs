using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Models.Testimonial
{
    public class TestimonialViewModel
    {
        [Key]
        public int Testimonialid { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
    }
}
