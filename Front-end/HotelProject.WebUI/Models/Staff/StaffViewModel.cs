using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Models.Staff
{
    public class StaffViewModel
    {
        [Key]

        public int Staffid { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        


    }
}
