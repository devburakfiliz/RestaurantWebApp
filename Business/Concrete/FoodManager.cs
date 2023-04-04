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
    public class FoodManager :IFoodService
    {
        private readonly IFoodDal _FoodDal;

        public FoodManager(IFoodDal foodDal)
        {
            _FoodDal = foodDal;
        }

        public void TDelete(Food t)
        {
            _FoodDal.Delete(t);
        }

        public Food TGetById(int id)
        {
            return _FoodDal.GetById(id);
        }

        public List<Food> TGetList()
        {
            return _FoodDal.GetList();
        }

        public void TInsert(Food t)
        {
            _FoodDal.Insert(t);
        }

        public void TUpdate(Food t)
        {
            _FoodDal.Update(t);
        }
    }
}
