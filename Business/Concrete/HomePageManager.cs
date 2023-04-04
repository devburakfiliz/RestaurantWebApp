using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class HomePageManager :IHomePageService
    {
        private readonly IHomePageDal _HomePageDal;

        public HomePageManager(IHomePageDal fomePageDal)
        {
            _HomePageDal = fomePageDal;
        }

        public void TDelete(HomePage t)
        {
            _HomePageDal.Delete(t);
        }

        public HomePage TGetById(int id)
        {
            return _HomePageDal.GetById(id);
        }

        public List<HomePage> TGetList()
        {
            return _HomePageDal.GetList();
        }

        public void TInsert(HomePage t)
        {
            _HomePageDal.Insert(t);
        }

        public void TUpdate(HomePage t)
        {
            _HomePageDal.Update(t);
        }
    }
}
