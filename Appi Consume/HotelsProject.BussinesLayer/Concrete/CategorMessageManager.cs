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
	public class CategorMessageManager : ICategorMessageService
	{
		private readonly ImmessageCategoryDal _ımmessageCategoryDal;

		public CategorMessageManager(ImmessageCategoryDal ımmessageCategoryDal)
		{
			_ımmessageCategoryDal = ımmessageCategoryDal;
		}

		public void tDelete(CategoreMessage t)
		{
			throw new NotImplementedException();
		}

		public CategoreMessage tGetByID(int id)
		{
			throw new NotImplementedException();
		}

		public List<CategoreMessage> tGetList()
		{
			return _ımmessageCategoryDal.GetList();
		}

		public void tInsert(CategoreMessage t)
		{
			throw new NotImplementedException();
		}

		public void tUpdate(CategoreMessage t)
		{
			throw new NotImplementedException();
		}
	}
}
