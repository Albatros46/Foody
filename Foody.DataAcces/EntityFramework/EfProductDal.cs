using Foody.DataAcces.Abstruct;
using Foody.DataAcces.Context;
using Foody.DataAcces.Repositories;
using Foody.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.DataAcces.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public EfProductDal(FoodyContext context) : base(context)
        {
        }
    }
}
