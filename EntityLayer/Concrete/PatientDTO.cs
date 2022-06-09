using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
  public  class PatientDTO
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public int Kota { get; set; }
        public int İncoming { get; set; }
        public int Going { get; set; }
        public int Remainder { get; set; }
        public DateTime StaringDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Amount { get; set; }
        public string SpecialityName { get; set; }
        public string phaseName { get; set; }
        public string ProName { get; set; }
        public string ProStatus { get; set; }
        public string ProType { get; set; }
        public string SponsorName { get; set; }
        public string MaterialName { get; set; }
        public string TubeName { get; set; }
        public string CancerName { get; set; }
    }
}
