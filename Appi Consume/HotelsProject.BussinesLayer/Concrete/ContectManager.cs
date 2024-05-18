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
    public class ContectManager : IContectService
    {
        private readonly IContectDal _contectDal;

        public ContectManager(IContectDal contectDal)
        {
            _contectDal = contectDal;
        }

        public void tDelete(Contect t)
        {
            _contectDal.Delete(t);
        }

        public Contect tGetByID(int id)
        {
            return _contectDal.GetByID(id);
        }

        public int TGetCountactCount()
        {
           return _contectDal.GetCountactCount();
        }

        public List<Contect> tGetList()
        {
            return _contectDal.GetList();
        }

        public void tInsert(Contect t)
        {
           _contectDal.Insert(t);
        }

        public void tUpdate(Contect t)
        {
            _contectDal.Update(t);
        }
    }
}
