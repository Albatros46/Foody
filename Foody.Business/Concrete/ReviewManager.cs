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
    public class ReviewManager:IReviewService
    {
        private readonly IReviewDal _dal;

        public ReviewManager(IReviewDal dal)
        {
            _dal = dal;
        }
        public void TDelete(int id)
        {
            _dal.Delete(id);
        }

        public List<Review> TGetAll()
        {
            return _dal.GetAll();
        }

        public Review TGetById(int id)
        {
            return _dal.GetById(id);
        }

        public void TInsert(Review entity)
        {
            _dal.Insert(entity);
        }

        public void TUpdate(Review entity)
        {
            _dal.Update(entity);
        }
    }
}
