using EntityLayer.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class ProjectType : IEntity
    {
        [Key]
        public int ProjectTypeId { get; set; }
        public string ProType { get; set; }
        public bool TypeStatus { get; set; }
        public ICollection<AdminList> AdminLists { get; set; }
    }

}
