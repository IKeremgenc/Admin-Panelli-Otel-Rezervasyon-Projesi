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
    public class AppuserManger : IAppuserService
    {
        private readonly IAppUserDal _appUserDal;

        public AppuserManger(IAppUserDal appUserDal)
        {
            _appUserDal = appUserDal;
        }

        public void tDelete(AppUser t)
        {
            throw new NotImplementedException();
        }

        public AppUser tGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<AppUser> tGetList()
        {
            return _appUserDal.GetList();   
        }

        public void tInsert(AppUser t)
        {
            throw new NotImplementedException();
        }

        public void tUpdate(AppUser t)
        {
            throw new NotImplementedException();
        }

        public List<AppUser> TUserWisthWorkLocations()
        {
            return _appUserDal.UserWisthWorkLocations();
        }

        public List<AppUser> TUserWithWorkLocation()
        {
           return _appUserDal.UserWithWorkLocation();
        }
    }
}
