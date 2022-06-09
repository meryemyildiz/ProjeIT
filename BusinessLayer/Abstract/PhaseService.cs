using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface PhaseService
    {
        List<Phase> GetList();
        void PhaseAdd(Phase phase);
        Phase GetById(int id);
        void PhaseDelete(Phase phase);
        void PhaseUpdate(Phase phase);
    }
}
