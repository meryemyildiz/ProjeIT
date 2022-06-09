using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
   public class Context:DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<AdminList> AdminLists { get; set; }
        public DbSet<AmountOfMaterial> AmountOfMaterials { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<PatientSpeciality> PatientSpecialities { get; set; }
        public DbSet<Phase> Phases { get; set; }
        public DbSet<ProjectName> ProjectNames { get; set; }
        public DbSet<ProjectStatus> ProjectStatuses { get; set; }
        public DbSet<ProjectType> ProjectTypes { get; set; }
        public DbSet<Sponsor> Sponsors { get; set; }
        public DbSet<TypeOfMaterial> TypeOfMaterials { get; set; }
        public DbSet<TypeOfTube> TypeOfTubes { get; set; }
        public DbSet<TypesOfCancer> TypesOfCancers { get; set; }

      
    }
}
