using HotelProject.DataAccsesLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using HotelsProject.BussinesLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelsProject.BussinesLayer.Concrete
{

    public class BookingManagewr : IBookingService
    {
        private readonly IBookingDal _bookingDal;

        public BookingManagewr(IBookingDal bookingDal)
        {
            _bookingDal = bookingDal;
        }

        public void BookingStatusChangeApprode(Booking booking)
        {
            _bookingDal.BookingStatusChangeApprode(booking);
        }

        public void BookingStatusChangeApprode2(int id)
        {
           _bookingDal.BookingStatusChangeApprode2(id);
        }

        public void tDelete(Booking t)
        {
            _bookingDal.Delete(t);
        }

        public Booking tGetByID(int id)
        {
            return _bookingDal.GetByID(id);
        }

        public List<Booking> tGetList()
        {
            return _bookingDal.GetList();
        }

        public void tInsert(Booking t)
        {
            _bookingDal.Insert(t);
        }

        public void tUpdate(Booking t)
        {
            _bookingDal.Update(t);
        }
    }
}
