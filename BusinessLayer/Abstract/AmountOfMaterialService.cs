using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface AmountOfMaterialService
    {
        List<AmountOfMaterial> GetList();
        void AmountOfMaterialAdd(AmountOfMaterial amountOfMaterial);
        AmountOfMaterial GetById(int id);
        void AmountOfMaterialDelete(AmountOfMaterial amountOfMaterial);
        void AmountOfMaterialUpdate(AmountOfMaterial amountOfMaterial);
    }
}
