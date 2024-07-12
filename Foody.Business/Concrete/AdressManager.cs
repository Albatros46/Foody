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
    public class AdressManager :IAdressService
    {
        private readonly IAdressDal _dal;

        public AdressManager(IAdressDal dal)
        {
            _dal = dal;
        }

        public void TDelete(int id)
        {
            _dal.Delete(id);
        }

        public List<Adress> TGetAll()
        {
            return _dal.GetAll();
        }

        public Adress TGetById(int id)
        {
            return _dal.GetById(id);
        }

        public void TInsert(Adress entity)
        {
            _dal.Insert(entity);
        }

        public void TUpdate(Adress entity)
        {
            _dal.Update(entity);
        }
    }
}
