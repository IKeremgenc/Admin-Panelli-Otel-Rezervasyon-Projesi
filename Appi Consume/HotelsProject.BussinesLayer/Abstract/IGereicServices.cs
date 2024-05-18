using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelsProject.BussinesLayer.Abstract
{
    public interface IGereicServices<T> where T : class
    {
        void tInsert(T t);
        void tDelete(T t);
        void tUpdate(T t);
        List<T> tGetList();
        T tGetByID(int id);
    }
}
