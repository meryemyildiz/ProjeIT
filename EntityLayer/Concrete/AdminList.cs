using EntityLayer.Abstract;
using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class AdminList : IEntity
    {
        [Key]
        public int Id { get; set; }
        public int Kota { get; set; }
        public int İncoming { get; set; }
        public int Going { get; set; }
        public int Remainder { get; set; }
        public DateTime? StaringDate { get; set; }
        public DateTime? EndDate { get; set; }

        public int AmountId { get; set; }
        public virtual AmountOfMaterial AmountOfMaterial { get; set; }

        public int PSpecialityId { get; set; }
        public virtual PatientSpeciality PatientSpeciality { get; set; }

        public int PhaseId { get; set; }
        public virtual Phase Phase { get; set; }

        public int NameId { get; set; }
        public virtual ProjectName ProjectName { get; set; }

        public int StatusId { get; set; }
        public virtual ProjectStatus ProjectStatus { get; set; }

        public int ProjectTypeId { get; set; }
        public virtual ProjectType ProjectType { get; set; }

        public int SponsorId { get; set; }
        public virtual Sponsor Sponsor { get; set; }

        public int MaterialId { get; set; }
        public virtual TypeOfMaterial TypeOfMaterial { get; set; }

        public int TubeId { get; set; }
        public virtual TypeOfTube TypeOfTube { get; set; }

        public int CancerId { get; set; }
        public virtual TypesOfCancer TypesOfCancer { get; set; }

     
    }

}
