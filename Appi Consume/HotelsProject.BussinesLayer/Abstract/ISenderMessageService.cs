using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelsProject.BussinesLayer.Abstract
{
    public interface ISenderMessageService:IGereicServices<SendMessage>
    {
        public int  TSendCountMessage();
    }
}
