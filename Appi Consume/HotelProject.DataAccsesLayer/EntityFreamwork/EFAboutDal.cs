using HotelProject.DataAccsesLayer.Abstract;
using HotelProject.DataAccsesLayer.Concrete;
using HotelProject.DataAccsesLayer.Repostories;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccsesLayer.EntityFreamwork
{
    public class EFAboutDal : GenericRepostories<About>, IAboutDal
    {
        public EFAboutDal(Context context) : base(context)
        {
        }
    }
}
