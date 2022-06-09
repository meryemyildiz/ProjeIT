using EntityLayer.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Sponsor : IEntity
    {
        [Key]
        public int SponsorId { get; set; }
        public string SponsorName { get; set; }
        public bool SponsorStatus { get; set; }
        public ICollection<AdminList> AdminLists { get; set; }
    }

}
