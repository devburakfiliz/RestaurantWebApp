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
    public class ChefManager : IChefService
    {
        private readonly IChefDal _ChefDal;

        public ChefManager(IChefDal chefDal)
        {
            _ChefDal = chefDal;
        }

        public void TDelete(Chef t)
        {
            _ChefDal.Delete(t);
        }

        public Chef TGetById(int id)
        {
            return _ChefDal.GetById(id);
        }

        public List<Chef> TGetList()
        {
            return _ChefDal.GetList();
        }

        public void TInsert(Chef t)
        {
            _ChefDal.Insert(t);
        }

        public void TUpdate(Chef t)
        {
            _ChefDal.Update(t);
        }
    }
}
