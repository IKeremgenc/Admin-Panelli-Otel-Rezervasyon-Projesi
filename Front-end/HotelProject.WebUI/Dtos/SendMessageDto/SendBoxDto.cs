using System;

namespace HotelProject.WebUI.Dtos.SendMessageDto
{
    public class SendBoxDto
    {
        public int SendMessageid { get; set; }
        public string ReciverName { get; set; }
        public string ReciverMail { get; set; }
        public string SenderName { get; set; }
        public string SenderMail { get; set; }
        public string title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
    }
}
