using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface PatientSpecialityService
    {
        List<PatientSpeciality> GetList();
        void PatientSpecialityAdd(PatientSpeciality patientSpeciality);
        PatientSpeciality GetById(int id);
        void PatientSpecialityDelete(PatientSpeciality patientSpeciality);
        void PatientSpecialityUpdate(PatientSpeciality patientSpeciality);
    }
}
