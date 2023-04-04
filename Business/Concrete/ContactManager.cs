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
    public class ContactManager : IContactService
    {
        private readonly IContactDal _ContactDal;

        public ContactManager(IContactDal contactDal)
        {
            _ContactDal = contactDal;
        }

        public void TDelete(Contact t)
        {
            _ContactDal.Delete(t);
        }

        public Contact TGetById(int id)
        {
            return _ContactDal.GetById(id);
        }

        public List<Contact> TGetList()
        {
            return _ContactDal.GetList();
        }

        public void TInsert(Contact t)
        {
            _ContactDal.Insert(t);
        }

        public void TUpdate(Contact t)
        {
            _ContactDal.Update(t);
        }
    }
}
