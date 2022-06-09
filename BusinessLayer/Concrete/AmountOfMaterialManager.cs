using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AmountOfMaterialManager : AmountOfMaterialService
    {
        IAmountOfMaterialDal _amountOfMaterialDal;

        public AmountOfMaterialManager(IAmountOfMaterialDal amountOfMaterialDal)
        {
            _amountOfMaterialDal = amountOfMaterialDal;
        }

        public void AmountOfMaterialAdd(AmountOfMaterial amountOfMaterial)
        {
            _amountOfMaterialDal.Insert(amountOfMaterial);
        }

        public void AmountOfMaterialDelete(AmountOfMaterial amountOfMaterial)
        {
            _amountOfMaterialDal.Update(amountOfMaterial);
        }

        public void AmountOfMaterialUpdate(AmountOfMaterial amountOfMaterial)
        {
            _amountOfMaterialDal.Update(amountOfMaterial);
        }

        public AmountOfMaterial GetById(int id)
        {
            return _amountOfMaterialDal.Get(x => x.AmountId == id);
        }

        public List<AmountOfMaterial> GetList()
        {
           
            return _amountOfMaterialDal.List();
        }
    }
}
