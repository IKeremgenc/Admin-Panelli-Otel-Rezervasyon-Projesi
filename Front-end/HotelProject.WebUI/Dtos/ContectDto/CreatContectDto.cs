using HotelProject.EntityLayer.Concrete;
using System;

namespace HotelProject.WebUI.Dtos.ContectDto
{
    public class CreatContectDto
    {
        public int Contectid { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
		public int MessageCategorid { get; set; }
		public CategoreMessage MessageCategore { get; set; }
	}
}
