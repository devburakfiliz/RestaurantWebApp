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
    public class Food5Manager : IFood5Service
    {
        private readonly IFood5Dal _Food5Dal;

        public Food5Manager(IFood5Dal food5Dal)
        {
            _Food5Dal = food5Dal;
        }

        public void TDelete(Food5 t)
        {
            _Food5Dal.Delete(t);
        }

        public Food5 TGetById(int id)
        {
            return _Food5Dal.GetById(id);
        }

        public List<Food5> TGetList()
        {
            return _Food5Dal.GetList();
        }

        public void TInsert(Food5 t)
        {
            _Food5Dal.Insert(t);
        }

        public void TUpdate(Food5 t)
        {
            _Food5Dal.Update(t);
        }
    }
}
