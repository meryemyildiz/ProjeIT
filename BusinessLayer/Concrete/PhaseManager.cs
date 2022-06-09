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
    public class PhaseManager : PhaseService
    {
        IPhaseDal _phaseDal;

        public PhaseManager(IPhaseDal phaseDal)
        {
            _phaseDal = phaseDal;
        }

        public Phase GetById(int id)
        {
            return _phaseDal.Get(x => x.PhaseId == id);
        }

        public List<Phase> GetList()
        {
            return _phaseDal.List();
        }

        public void PhaseAdd(Phase phase)
        {
            _phaseDal.Insert(phase);
        }

        public void PhaseDelete(Phase phase)
        {
            _phaseDal.Update(phase);
        }

        public void PhaseUpdate(Phase phase)
        {
            _phaseDal.Update(phase);
        }
    }
}
