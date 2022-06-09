using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface TypeOfMaterialService
    {
        List<TypeOfMaterial> GetList();
        void TypeOfMaterialAdd(TypeOfMaterial typeOfMaterial);
        TypeOfMaterial GetById(int id);
        void TypeOfMaterialrDelete(TypeOfMaterial typeOfMaterial);
        void TypeOfMaterialUpdate(TypeOfMaterial typeOfMaterial);
    }
}
