using EntityLayer.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class TypeOfMaterial : IEntity
    {
        [Key]
        public int MaterialId { get; set; }
        public string MaterialName { get; set; }
        public bool MaterialStatus { get; set; }
        public ICollection<AdminList> AdminLists { get; set; }
    }

}
