using EntityLayer.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class AmountOfMaterial : IEntity
    {
        [Key]
        public int AmountId { get; set; }
        public string Amount { get; set; }
        public bool AmountStatus { get; set; }
        public ICollection<AdminList> AdminLists { get; set; }
    }

}
