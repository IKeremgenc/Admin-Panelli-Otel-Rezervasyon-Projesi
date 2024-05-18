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
    public class SubscribeManager : ISubscribeService
    {
        private readonly ISubscribesDal _subscribesDal;

        public SubscribeManager(ISubscribesDal subscribesDal)
        {
            _subscribesDal = subscribesDal;
        }

        public void tDelete(Subscribe t)
        {
           _subscribesDal.Delete(t);
        }

        public Subscribe tGetByID(int id)
        {
           return _subscribesDal.GetByID(id);
        }

        public List<Subscribe> tGetList()
        {
           return _subscribesDal.GetList();
        }

        public void tInsert(Subscribe t)
        {
          _subscribesDal.Insert(t);
        }

        public void tUpdate(Subscribe t)
        {
           _subscribesDal.Update(t);
        }
    }
}
