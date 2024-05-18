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
    public class StaffManager : IStaffService
    {
        private readonly IStaffDal _staffDal;

        public StaffManager(IStaffDal staffDal)
        {
            _staffDal = staffDal;
        }

        public void tDelete(Staff t)
        {
            _staffDal.Delete(t);
        }

        public Staff tGetByID(int id)
        {
           return _staffDal.GetByID(id);    
        }

        public List<Staff> tGetList()
        {
           return _staffDal.GetList();
        }

        public void tInsert(Staff t)
        {
           _staffDal.Insert(t);
        }

        public void tUpdate(Staff t)
        {
           _staffDal.Update(t); 
        }
    }
}
