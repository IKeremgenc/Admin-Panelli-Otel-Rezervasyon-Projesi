using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccsesLayer.Abstract
{
    public interface IBookingDal:IGenericDal<Booking>
    {
        void BookingStatusChangeApprode(Booking booking);
        void BookingStatusChangeApprode2(int id);
    }
}
