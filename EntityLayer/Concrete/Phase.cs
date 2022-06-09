using EntityLayer.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Phase : IEntity
    {
        [Key]
        public int PhaseId { get; set; }
        public string phaseName { get; set; }
        public bool PhaseStatus { get; set; }
        public ICollection<AdminList> AdminLists { get; set; }
    }

}
