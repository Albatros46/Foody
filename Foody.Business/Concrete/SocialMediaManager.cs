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
    public class SocialMediaManager:ISocialMediaService
    {
        private readonly ISocialMediaDal _dal;

        public SocialMediaManager(ISocialMediaDal dal)
        {
            _dal = dal;
        }
        public void TDelete(int id)
        {
            _dal.Delete(id);
        }

        public List<SocialMedia> TGetAll()
        {
            return _dal.GetAll();
        }

        public SocialMedia TGetById(int id)
        {
            return _dal.GetById(id);
        }

        public void TInsert(SocialMedia entity)
        {
            _dal.Insert(entity);
        }

        public void TUpdate(SocialMedia entity)
        {
            _dal.Update(entity);
        }
    }
}
