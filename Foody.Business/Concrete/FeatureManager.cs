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
    public class FeatureManager:IFeatureService
    {
        private readonly IFeatureDal _dal;

        public FeatureManager(IFeatureDal dal)
        {
            _dal = dal;
        }
        public void TDelete(int id)
        {
            _dal.Delete(id);
        }

        public List<Feature> TGetAll()
        {
            return _dal.GetAll();
        }

        public Feature TGetById(int id)
        {
            return _dal.GetById(id);
        }

        public void TInsert(Feature entity)
        {
            _dal.Insert(entity);
        }

        public void TUpdate(Feature entity)
        {
            _dal.Update(entity);
        }
    }
}
