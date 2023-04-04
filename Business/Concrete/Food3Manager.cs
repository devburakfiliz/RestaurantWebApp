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
    public class Food3Manager :IFood3Service
    {
        private readonly IFood3Dal _Food3Dal;

        public Food3Manager(IFood3Dal food3Dal)
        {
            _Food3Dal = food3Dal;
        }

        public void TDelete(Food3 t)
        {
            _Food3Dal.Delete(t);
        }

        public Food3 TGetById(int id)
        {
            return _Food3Dal.GetById(id);
        }

        public List<Food3> TGetList()
        {
            return _Food3Dal.GetList();
        }

        public void TInsert(Food3 t)
        {
            _Food3Dal.Insert(t);
        }

        public void TUpdate(Food3 t)
        {
            _Food3Dal.Update(t);
        }
    }
}
