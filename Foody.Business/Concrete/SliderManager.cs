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
    public class SliderManager:ISliderService
    {
        private readonly ISliderDal _dal;

        public SliderManager(ISliderDal dal)
        {
            _dal = dal;
        }
        public void TDelete(int id)
        {
            _dal.Delete(id);
        }

        public List<Slider> TGetAll()
        {
            return _dal.GetAll();
        }

        public Slider TGetById(int id)
        {
            return _dal.GetById(id);
        }

        public void TInsert(Slider entity)
        {
            _dal.Insert(entity);
        }

        public void TUpdate(Slider entity)
        {
            _dal.Update(entity);
        }
    }
}
