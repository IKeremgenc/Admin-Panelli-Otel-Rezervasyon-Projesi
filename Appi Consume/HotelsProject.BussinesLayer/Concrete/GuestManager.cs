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
    public class GuestManager : IGuestServie
    {
        private readonly IGuestDalcs _guestDalcs;

        public GuestManager(IGuestDalcs guestDalcs)
        {
            _guestDalcs = guestDalcs;
        }

        public void tDelete(Guest t)
        {
            _guestDalcs.Delete(t);
           
        }

        public Guest tGetByID(int id)
        {
          return _guestDalcs.GetByID(id);
        }

        public List<Guest> tGetList()
        {
        return _guestDalcs.GetList();
        }

        public void tInsert(Guest t)
        {
            _guestDalcs.Insert(t);
        }

        public void tUpdate(Guest t)
        {
            _guestDalcs.Update(t);
        }
    }
}
