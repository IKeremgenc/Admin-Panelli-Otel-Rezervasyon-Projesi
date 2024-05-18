using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccsesLayer.Abstract
{
    public interface IAppUserDal: IGenericDal<AppUser>
    {

        List<AppUser> UserWithWorkLocation();
        List<AppUser> UserWisthWorkLocations();
    }
}
