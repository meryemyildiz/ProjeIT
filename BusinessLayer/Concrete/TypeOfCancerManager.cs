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
    public class TypeOfCancerManager : TypesOfCancerService
    {
        ITypesOfCancerDal _typesOfCancerDal;

        public TypeOfCancerManager(ITypesOfCancerDal typesOfCancerDal)
        {
            _typesOfCancerDal = typesOfCancerDal;
        }
        public TypesOfCancer GetById(int id)
        {
            return _typesOfCancerDal.Get(x => x.CancerId == id);
        }

        public List<TypesOfCancer> GetList()
        {
            return _typesOfCancerDal.List();
        }

        public void TypeOfCancerDelete(TypesOfCancer typesOfCancer)
        {
            _typesOfCancerDal.Update(typesOfCancer);
        }

        public void TypeOfCancerUpdate(TypesOfCancer typesOfCancer)
        {
            _typesOfCancerDal.Update(typesOfCancer);
        }

        public void TypesOfCancerAdd(TypesOfCancer typesOfCancer)
        {
            _typesOfCancerDal.Insert(typesOfCancer);
        }
    }
}