using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.EntityLayer.Concrete
{
    public class SendMessage
    {
        [Key]
        public int SendMessageid { get; set; }
        public string ReciverName { get; set; }
        public string ReciverMail { get; set; }
        public string SenderName { get; set; }
        public string SenderMail { get; set; }
        public string title { get; set; }
        public string Content { get; set; }
        public DateTime Date{ get; set; }
    }
}
