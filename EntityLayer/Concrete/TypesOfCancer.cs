using EntityLayer.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class TypesOfCancer : IEntity
    {
        [Key]
        public int CancerId { get; set; }
        public string CancerName { get; set; }
        public bool CancerStatus { get; set; }
        public ICollection<AdminList> AdminLists { get; set; }
    }

}
