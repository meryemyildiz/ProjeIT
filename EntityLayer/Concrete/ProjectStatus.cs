using EntityLayer.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class ProjectStatus : IEntity
    {
        [Key]
        public int StatusId { get; set; }
        public string ProStatus { get; set; }
        public bool ProjeStatus { get; set; }
        public ICollection<AdminList> AdminLists { get; set; }
    }

}
