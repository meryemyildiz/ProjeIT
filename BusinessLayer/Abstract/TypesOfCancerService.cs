using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface TypesOfCancerService
    {
           List<TypesOfCancer> GetList();
           void TypesOfCancerAdd(TypesOfCancer typesOfCancer);
           TypesOfCancer GetById(int id);
           void TypeOfCancerDelete(TypesOfCancer typesOfCancer);
           void TypeOfCancerUpdate(TypesOfCancer typesOfCancer);
    }
}
