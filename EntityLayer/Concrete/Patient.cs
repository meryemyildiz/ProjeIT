using EntityLayer.Abstract;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Patient : IEntity
    {
        [Key]
        public int PatientId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int ProjeId { get; set; }
        public string Role { get; set; } = "K";
    }

}
