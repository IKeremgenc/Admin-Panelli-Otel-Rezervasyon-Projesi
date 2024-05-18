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
    public class ServiceManager_ : IServiceServices
    {
        private readonly IServicesDal _servicesDal;

        public ServiceManager_(IServicesDal servicesDal)
        {
            _servicesDal = servicesDal;
        }

        public void tDelete(Services t)
        {
           _servicesDal.Delete(t);
        }

        public Services tGetByID(int id)
        {
       return    _servicesDal.GetByID(id);
        }

        public List<Services> tGetList()
        {
            return _servicesDal.GetList();
        }

        public void tInsert(Services t)
        {
          _servicesDal.Insert(t);
        }

        public void tUpdate(Services t)
        {
           _servicesDal.Update(t);
        }
    }
}
