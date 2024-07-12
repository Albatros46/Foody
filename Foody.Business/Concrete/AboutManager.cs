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
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal _dal;

        public AboutManager(IAboutDal dal)
        {
            _dal = dal;
        }

        public void TDelete(int id)
        {
            _dal.Delete(id);
        }

        public List<About> TGetAll()
        {
            return _dal.GetAll();
        }

        public About TGetById(int id)
        {
            return _dal.GetById(id);
        }

        public void TInsert(About entity)
        {
            _dal.Insert(entity);
        }

        public void TUpdate(About entity)
        {
            _dal.Update(entity);
        }
    }
}
