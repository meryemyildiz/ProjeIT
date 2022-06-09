using EntityLayer.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class PatientSpeciality : IEntity
    {
        [Key]
        public int PSpecialityId { get; set; }
        public string SpecialityName { get; set; }
        public bool SpecialityStatus { get; set; }
        public ICollection<AdminList> AdminLists { get; set; }
    }

}
