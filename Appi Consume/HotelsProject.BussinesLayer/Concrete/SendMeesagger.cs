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
    public class SendMeesagger : ISenderMessageService
    {
        private readonly ISendMessageDal _sendMessageDal;

        public SendMeesagger(ISendMessageDal sendMessageDal)
        {
            _sendMessageDal = sendMessageDal;
        }

        public void tDelete(SendMessage t)
        {
           _sendMessageDal.Delete(t);
        }

        public SendMessage tGetByID(int id)
        {
            return _sendMessageDal.GetByID(id); 
        }

        public List<SendMessage> tGetList()
        {
         return _sendMessageDal.GetList();
        }

        public void tInsert(SendMessage t)
        {
            _sendMessageDal.Insert(t);
        }

        public int TSendCountMessage()
        {
            return _sendMessageDal.SendCountMessage();
        }

        public void tUpdate(SendMessage t)
        {
           _sendMessageDal?.Update(t);
        }
    }
}
