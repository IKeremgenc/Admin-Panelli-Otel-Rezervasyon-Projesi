using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int Aboutid { get; set; }
        public string Description { get; set; }
        public int RoomCount { get; set; }
        public int StafCount { get; set; }
        public int ClientCount { get; set; }
    }
}
