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
    public class Food4Manager :IFood4Service
    {
        private readonly IFood4Dal _Food4Dal;

        public Food4Manager(IFood4Dal food4Dal)
        {
            _Food4Dal = food4Dal;
        }

        public void TDelete(Food4 t)
        {
            _Food4Dal.Delete(t);
        }

        public Food4 TGetById(int id)
        {
            return _Food4Dal.GetById(id);
        }

        public List<Food4> TGetList()
        {
            return _Food4Dal.GetList();
        }

        public void TInsert(Food4 t)
        {
            _Food4Dal.Insert(t);
        }

        public void TUpdate(Food4 t)
        {
            _Food4Dal.Update(t);
        }
    }
}
