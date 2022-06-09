namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialize : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdminLists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Kota = c.Int(nullable: false),
                        İncoming = c.Int(nullable: false),
                        Going = c.Int(nullable: false),
                        Remainder = c.Int(nullable: false),
                        StaringDate = c.DateTime(),
                        EndDate = c.DateTime(),
                        AmountId = c.Int(nullable: false),
                        PSpecialityId = c.Int(nullable: false),
                        PhaseId = c.Int(nullable: false),
                        NameId = c.Int(nullable: false),
                        StatusId = c.Int(nullable: false),
                        ProjectTypeId = c.Int(nullable: false),
                        SponsorId = c.Int(nullable: false),
                        MaterialId = c.Int(nullable: false),
                        TubeId = c.Int(nullable: false),
                        CancerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AmountOfMaterials", t => t.AmountId, cascadeDelete: true)
                .ForeignKey("dbo.PatientSpecialities", t => t.PSpecialityId, cascadeDelete: true)
                .ForeignKey("dbo.Phases", t => t.PhaseId, cascadeDelete: true)
                .ForeignKey("dbo.ProjectNames", t => t.NameId, cascadeDelete: true)
                .ForeignKey("dbo.ProjectStatus", t => t.StatusId, cascadeDelete: true)
                .ForeignKey("dbo.ProjectTypes", t => t.ProjectTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Sponsors", t => t.SponsorId, cascadeDelete: true)
                .ForeignKey("dbo.TypeOfMaterials", t => t.MaterialId, cascadeDelete: true)
                .ForeignKey("dbo.TypeOfTubes", t => t.TubeId, cascadeDelete: true)
                .ForeignKey("dbo.TypesOfCancers", t => t.CancerId, cascadeDelete: true)
                .Index(t => t.AmountId)
                .Index(t => t.PSpecialityId)
                .Index(t => t.PhaseId)
                .Index(t => t.NameId)
                .Index(t => t.StatusId)
                .Index(t => t.ProjectTypeId)
                .Index(t => t.SponsorId)
                .Index(t => t.MaterialId)
                .Index(t => t.TubeId)
                .Index(t => t.CancerId);
            
            CreateTable(
                "dbo.AmountOfMaterials",
                c => new
                    {
                        AmountId = c.Int(nullable: false, identity: true),
                        Amount = c.String(),
                        AmountStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.AmountId);
            
            CreateTable(
                "dbo.PatientSpecialities",
                c => new
                    {
                        PSpecialityId = c.Int(nullable: false, identity: true),
                        SpecialityName = c.String(),
                        SpecialityStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.PSpecialityId);
            
            CreateTable(
                "dbo.Phases",
                c => new
                    {
                        PhaseId = c.Int(nullable: false, identity: true),
                        phaseName = c.String(),
                        PhaseStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.PhaseId);
            
            CreateTable(
                "dbo.ProjectNames",
                c => new
                    {
                        NameId = c.Int(nullable: false, identity: true),
                        ProName = c.String(),
                    })
                .PrimaryKey(t => t.NameId);
            
            CreateTable(
                "dbo.ProjectStatus",
                c => new
                    {
                        StatusId = c.Int(nullable: false, identity: true),
                        ProStatus = c.String(),
                        ProjeStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.StatusId);
            
            CreateTable(
                "dbo.ProjectTypes",
                c => new
                    {
                        ProjectTypeId = c.Int(nullable: false, identity: true),
                        ProType = c.String(),
                        TypeStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ProjectTypeId);
            
            CreateTable(
                "dbo.Sponsors",
                c => new
                    {
                        SponsorId = c.Int(nullable: false, identity: true),
                        SponsorName = c.String(),
                        SponsorStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.SponsorId);
            
            CreateTable(
                "dbo.TypeOfMaterials",
                c => new
                    {
                        MaterialId = c.Int(nullable: false, identity: true),
                        MaterialName = c.String(),
                        MaterialStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MaterialId);
            
            CreateTable(
                "dbo.TypeOfTubes",
                c => new
                    {
                        TubeId = c.Int(nullable: false, identity: true),
                        TubeName = c.String(),
                        TubeStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.TubeId);
            
            CreateTable(
                "dbo.TypesOfCancers",
                c => new
                    {
                        CancerId = c.Int(nullable: false, identity: true),
                        CancerName = c.String(),
                        CancerStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CancerId);
            
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        AdminId = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                        AdminRole = c.String(),
                    })
                .PrimaryKey(t => t.AdminId);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        PatientId = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                        ProjeId = c.Int(nullable: false),
                        Role = c.String(),
                    })
                .PrimaryKey(t => t.PatientId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AdminLists", "CancerId", "dbo.TypesOfCancers");
            DropForeignKey("dbo.AdminLists", "TubeId", "dbo.TypeOfTubes");
            DropForeignKey("dbo.AdminLists", "MaterialId", "dbo.TypeOfMaterials");
            DropForeignKey("dbo.AdminLists", "SponsorId", "dbo.Sponsors");
            DropForeignKey("dbo.AdminLists", "ProjectTypeId", "dbo.ProjectTypes");
            DropForeignKey("dbo.AdminLists", "StatusId", "dbo.ProjectStatus");
            DropForeignKey("dbo.AdminLists", "NameId", "dbo.ProjectNames");
            DropForeignKey("dbo.AdminLists", "PhaseId", "dbo.Phases");
            DropForeignKey("dbo.AdminLists", "PSpecialityId", "dbo.PatientSpecialities");
            DropForeignKey("dbo.AdminLists", "AmountId", "dbo.AmountOfMaterials");
            DropIndex("dbo.AdminLists", new[] { "CancerId" });
            DropIndex("dbo.AdminLists", new[] { "TubeId" });
            DropIndex("dbo.AdminLists", new[] { "MaterialId" });
            DropIndex("dbo.AdminLists", new[] { "SponsorId" });
            DropIndex("dbo.AdminLists", new[] { "ProjectTypeId" });
            DropIndex("dbo.AdminLists", new[] { "StatusId" });
            DropIndex("dbo.AdminLists", new[] { "NameId" });
            DropIndex("dbo.AdminLists", new[] { "PhaseId" });
            DropIndex("dbo.AdminLists", new[] { "PSpecialityId" });
            DropIndex("dbo.AdminLists", new[] { "AmountId" });
            DropTable("dbo.Patients");
            DropTable("dbo.Admins");
            DropTable("dbo.TypesOfCancers");
            DropTable("dbo.TypeOfTubes");
            DropTable("dbo.TypeOfMaterials");
            DropTable("dbo.Sponsors");
            DropTable("dbo.ProjectTypes");
            DropTable("dbo.ProjectStatus");
            DropTable("dbo.ProjectNames");
            DropTable("dbo.Phases");
            DropTable("dbo.PatientSpecialities");
            DropTable("dbo.AmountOfMaterials");
            DropTable("dbo.AdminLists");
        }
    }
}
