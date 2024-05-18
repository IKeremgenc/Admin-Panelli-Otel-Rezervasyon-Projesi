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
    public class WorkLocationManager : IWorkLocationService
    {
        private readonly IWorkLocationDal _workLocationDal;

        public WorkLocationManager(IWorkLocationDal workLocationDal)
        {
            _workLocationDal = workLocationDal;
        }

        public void tDelete(WorkLocation t)
        {
           _workLocationDal.Delete(t);
        }

        public WorkLocation tGetByID(int id)
        {
        return   _workLocationDal.GetByID(id);
        }

        public List<WorkLocation> tGetList()
        {
            return _workLocationDal.GetList();
        }

        public void tInsert(WorkLocation t)
        {
          _workLocationDal.Insert(t);
        }

        public void tUpdate(WorkLocation t)
        {
           _workLocationDal.Update(t);
        }
    }
}
