using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.EntityLayer.Concrete
{
    public class CategoreMessage
    {
        [Key]
        public int MessageCategorid { get; set; }
        public string MessageName { get; set; }
        public  List<Contect> Contects { get; set; }
    }
}
