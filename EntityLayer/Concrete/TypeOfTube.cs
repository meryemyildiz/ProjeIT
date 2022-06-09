using EntityLayer.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class TypeOfTube : IEntity
    {
        [Key]
        public int TubeId { get; set; }
        public string TubeName { get; set; }
        public bool TubeStatus { get; set; }
        public ICollection<AdminList> AdminLists { get; set; }
    }

}
