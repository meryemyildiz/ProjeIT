using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface TypeOfTubeService
    {
        List<TypeOfTube> GetList();
        void TypeOfTubeAdd(TypeOfTube typeOfTube);
        TypeOfTube GetById(int id);
        void TypeOfTubeDelete(TypeOfTube typeOfTube);
        void TypeOfTubeUpdate(TypeOfTube typeOfTube);
    }
}
