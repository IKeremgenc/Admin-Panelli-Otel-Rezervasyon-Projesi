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
    public class EFSendMessageDal : GenericRepostories<SendMessage>, ISendMessageDal
    {
        public EFSendMessageDal(Context context) : base(context)
        {
        }

        public int SendCountMessage()
        {
            var context=new Context();
            return context.sendMessages.Count();
        }
    }
}
