using Foody.Business.Abstract;
using Foody.DataAcces.Abstruct;
using Foody.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.Business.Concrete
{
    public class ProductManager:IProductService
    {
        private readonly IProductDal _dal;

        public ProductManager(IProductDal dal)
        {
            _dal = dal;
        }

        public void TDelete(int id)
        {
            _dal.Delete(id);
        }

        public List<Product> TGetAll()
        {
            return _dal.GetAll();
        }

        public Product TGetById(int id)
        {
            return _dal.GetById(id);
        }

        public void TInsert(Product entity)
        {
            _dal.Insert(entity);
        }

        public void TUpdate(Product entity)
        {
            _dal.Update(entity);
        }
    }
}
