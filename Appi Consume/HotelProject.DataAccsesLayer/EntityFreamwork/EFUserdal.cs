using HotelProject.DataAccsesLayer.Abstract;
using HotelProject.DataAccsesLayer.Concrete;
using HotelProject.DataAccsesLayer.Repostories;
using HotelProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccsesLayer.EntityFreamwork
{
    public class EFUserdal : GenericRepostories<AppUser>, IAppUserDal
    {
        public EFUserdal(Context context) : base(context)
        {
        }

        public List<AppUser> UserWisthWorkLocations()
        {
            var contex = new Context();
            return contex.Users.Include(x => x.WorkLocation).ToList();
        }

        public List<AppUser> UserWithWorkLocation()
        {
            var contex = new Context();
            return contex.Users.Include(x => x.WorkLocation).ToList();
        }
    }
}
