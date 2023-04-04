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
    public class SocialManager : ISocialService
    {
        private readonly ISocialDal _SocialDal;

        public SocialManager(ISocialDal socialDal)
        {
            _SocialDal = socialDal;
        }

        public void TDelete(Social t)
        {
            _SocialDal.Delete(t);
        }

        public Social TGetById(int id)
        {
            return _SocialDal.GetById(id);
        }

        public List<Social> TGetList()
        {
            return _SocialDal.GetList();
        }

        public void TInsert(Social t)
        {
            _SocialDal.Insert(t);
        }

        public void TUpdate(Social t)
        {
            _SocialDal.Update(t);
        }
    }
}
