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
    public class EFContectDal:GenericRepostories<Contect>,IContectDal
    {
        public EFContectDal(Context context) : base(context)
        {

        }

        public int GetCountactCount()
        {
           var context =new Context();
            var value = context.Contects.Count();
            return value;
        }
    }
}
