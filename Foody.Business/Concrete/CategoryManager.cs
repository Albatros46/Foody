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
    public class CategoryManager:ICategoryService
    {
        private readonly ICategoryDal _dal;

        public CategoryManager(ICategoryDal dal)
        {
            _dal = dal;
        }
    

        public void TDelete(int id)
        {
            _dal.Delete(id);
        }

        public List<Category> TGetAll()
        {
            return _dal.GetAll();
        }

        public Category TGetById(int id)
        {
            return _dal.GetById(id);
        }

        public void TInsert(Category entity)
        {
            _dal.Insert(entity);
        }

        public void TUpdate(Category entity)
        {
            _dal.Update(entity);
        }
    }
}
