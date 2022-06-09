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
    public class TypeOfTubeManager : TypeOfTubeService
    {
        ITypeOfTubeDal _typeOfTubeDal;

        public TypeOfTubeManager(ITypeOfTubeDal typeOfTubeDal)
        {
            _typeOfTubeDal = typeOfTubeDal;
        }

        public TypeOfTube GetById(int id)
        {
            return _typeOfTubeDal.Get(x => x.TubeId == id);
        }

        public List<TypeOfTube> GetList()
        {
            return _typeOfTubeDal.List();
        }

        public void TypeOfTubeDelete(TypeOfTube typeOfTube)
        {
            _typeOfTubeDal.Update(typeOfTube);
        }

        public void TypeOfTubeUpdate(TypeOfTube typeOfTube)
        {
            _typeOfTubeDal.Update(typeOfTube);
        }

        public void TypeOfTubeAdd(TypeOfTube typeOfTube)
        {
            _typeOfTubeDal.Insert(typeOfTube);
        }
    }
}
