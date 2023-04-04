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
    public class Food2Manager :IFood2Service
    {
        private readonly IFood2Dal _Food2Dal;

        public Food2Manager(IFood2Dal food2Dal)
        {
            _Food2Dal = food2Dal;
        }

        public void TDelete(Food2 t)
        {
            _Food2Dal.Delete(t);
        }

        public Food2 TGetById(int id)
        {
            return _Food2Dal.GetById(id);
        }

        public List<Food2> TGetList()
        {
            return _Food2Dal.GetList();
        }

        public void TInsert(Food2 t)
        {
            _Food2Dal.Insert(t);
        }

        public void TUpdate(Food2 t)
        {
            _Food2Dal.Update(t);
        }
    }
}
