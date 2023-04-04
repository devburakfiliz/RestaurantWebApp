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
    public class EfFood5Dal : GenericRepository<Food5>, IFood5Dal
    {
        public EfFood5Dal(Context context) : base(context)
        {

        }
    }
}
