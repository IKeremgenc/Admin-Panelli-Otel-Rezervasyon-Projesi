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
    public class AboutManger : IAboutService
    {

        private readonly IAboutDal _aboutDal;

        public AboutManger(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void tDelete(About t)
        {
            _aboutDal.Delete(t);
        }

        public About tGetByID(int id)
        {
            return _aboutDal.GetByID(id);   
        }

        public List<About> tGetList()
        {
            return _aboutDal.GetList();
        }

        public void tInsert(About t)
        {
            _aboutDal.Insert(t);
        }

        public void tUpdate(About t)
        {
            _aboutDal.Update(t);
        }
    }
}
