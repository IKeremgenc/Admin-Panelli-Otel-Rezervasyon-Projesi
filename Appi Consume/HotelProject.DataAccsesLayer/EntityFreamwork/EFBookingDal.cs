using HotelProject.DataAccsesLayer.Abstract;
using HotelProject.DataAccsesLayer.Concrete;
using HotelProject.DataAccsesLayer.Repostories;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccsesLayer.EntityFreamwork
{
    public class EFBookingDal:GenericRepostories<Booking>,IBookingDal
    {
        public EFBookingDal(Context context): base(context) 
        {

        }

        public void BookingStatusChangeApprode(Booking booking)
        {
            var context = new Context();
           var values=   context.Bookings.Where(x=>x.Bookingid==booking.Bookingid).FirstOrDefault();
            values.Statues = "Onaylandı";
            context.SaveChanges();
          
        }

        public void BookingStatusChangeApprode2(int id)
        {
            var context = new Context();
            var values = context.Bookings.Find(id);
            values.Statues = "Onaylandı";
            context.SaveChanges();
        }
    }
}
