using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Repositories;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityFramework
{
    public class EfFood4Dal : GenericRepository<Food4>, IFood4Dal
    {
        public EfFood4Dal(Context context) : base(context)
        {

        }
    }
}
