using EntityLayer.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ProjectName : IEntity
    {
        [Key]
        public int NameId { get; set; }
        public string ProName { get; set; }

        public ICollection<AdminList> AdminLists { get; set; }
    }

}
