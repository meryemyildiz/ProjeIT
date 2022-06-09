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
    public class PatientSpecialityManager : PatientSpecialityService
    {
        IPatientSpecialityDal _patientSpecialityDal;

        public PatientSpecialityManager(IPatientSpecialityDal patientSpecialityDal)
        {
            _patientSpecialityDal = patientSpecialityDal;
        }

        public PatientSpeciality GetById(int id)
        {
           return _patientSpecialityDal.Get(x => x.PSpecialityId == id);
        }

        public List<PatientSpeciality> GetList()
        {
           
            return _patientSpecialityDal.List();
        }

        public void PatientSpecialityAdd(PatientSpeciality patientSpeciality)
        {
            _patientSpecialityDal.Insert(patientSpeciality);
        }

        public void PatientSpecialityDelete(PatientSpeciality patientSpeciality)
        {
            _patientSpecialityDal.Update(patientSpeciality);
        }

        public void PatientSpecialityUpdate(PatientSpeciality patientSpeciality)
        {
            _patientSpecialityDal.Update(patientSpeciality);
        }
    }
}
