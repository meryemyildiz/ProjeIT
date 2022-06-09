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
    public class TypeOfMaterialManager : TypeOfMaterialService
    {
        ITypeOfMaterialDal _typeOfMaterialDal;

        public TypeOfMaterialManager(ITypeOfMaterialDal typeOfMaterialDal)
        {
            _typeOfMaterialDal = typeOfMaterialDal;
        }

        public TypeOfMaterial GetById(int id)
        {
            return _typeOfMaterialDal.Get(x => x.MaterialId == id);
        }

        public List<TypeOfMaterial> GetList()
        {
            return _typeOfMaterialDal.List();
        }

        public void TypeOfMaterialAdd(TypeOfMaterial typeOfMaterial)
        {
            _typeOfMaterialDal.Insert(typeOfMaterial);
        }

        public void TypeOfMaterialrDelete(TypeOfMaterial typeOfMaterial)
        {
            _typeOfMaterialDal.Update(typeOfMaterial);
        }

        public void TypeOfMaterialUpdate(TypeOfMaterial typeOfMaterial)
        {
            _typeOfMaterialDal.Update(typeOfMaterial);
        }
    }
}
