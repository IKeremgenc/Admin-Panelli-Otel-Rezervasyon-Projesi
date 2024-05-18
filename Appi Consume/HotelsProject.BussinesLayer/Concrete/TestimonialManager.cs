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
    public class TestimonialManager : ITestimonailService
    {
        private readonly ITestimonailDal _testimonailDal;

        public TestimonialManager(ITestimonailDal testimonailDal)
        {
            _testimonailDal = testimonailDal;
        }

        public void tDelete(Testimonial t)
        {
            _testimonailDal.Delete(t);
        }

        public Testimonial tGetByID(int id)
        {
        return  _testimonailDal.GetByID(id);
        }

        public List<Testimonial> tGetList()
        {
            return _testimonailDal.GetList();   
        }

        public void tInsert(Testimonial t)
        {
            _testimonailDal.Insert(t);
        }

        public void tUpdate(Testimonial t)
        {
            _testimonailDal.Update(t);
        }
    }
}
