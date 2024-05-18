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
    public class RoomManager : IRoomService
    {
        private readonly IRoomDal _roomDal;

        public RoomManager(IRoomDal roomDal)
        {
            _roomDal = roomDal;
        }

        public void tDelete(Room t)
        {
           _roomDal.Delete(t);
        }

        public Room tGetByID(int id)
        {
         return  _roomDal.GetByID(id);
        }

        public List<Room> tGetList()
        {
            return _roomDal.GetList();  
        }

        public void tInsert(Room t)
        {
           _roomDal.Insert(t);
        }

        public void tUpdate(Room t)
        {
            _roomDal.Update(t);
        }
    }
}
