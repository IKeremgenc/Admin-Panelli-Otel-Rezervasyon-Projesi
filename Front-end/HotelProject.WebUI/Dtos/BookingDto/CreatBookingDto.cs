using System;

namespace HotelProject.WebUI.Dtos.BookingDto
{
    public class CreatBookingDto
    {
        public int Bookingid { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public DateTime checkin { get; set; }
        public DateTime checkOut { get; set; }
        public string AdultCount { get; set; }
        public string ChildCount { get; set; }
        public string RoomCount { get; set; }
        public string SpecialRequest { get; set; }
        public string Description { get; set; }
        public string Statues { get; set; }
    }
}
