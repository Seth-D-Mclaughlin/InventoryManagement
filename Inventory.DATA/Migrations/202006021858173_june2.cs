namespace Inventory.DATA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class june2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Projects", "CaseId", "dbo.Cases");
            DropForeignKey("dbo.Projects", "CoolerId", "dbo.CPUCoolers");
            DropForeignKey("dbo.Projects", "CpuId", "dbo.CPUs");
            DropForeignKey("dbo.Projects", "MemoryId", "dbo.Memories");
            DropForeignKey("dbo.Projects", "MotherboardId", "dbo.Motherboards");
            DropForeignKey("dbo.Projects", "PsuId", "dbo.PowerSupplyUnits");
            DropForeignKey("dbo.Projects", "VideoId", "dbo.VideoCards");
            DropPrimaryKey("dbo.Cases");
            DropPrimaryKey("dbo.CPUCoolers");
            DropPrimaryKey("dbo.CPUs");
            DropPrimaryKey("dbo.Storages");
            DropPrimaryKey("dbo.Memories");
            DropPrimaryKey("dbo.Motherboards");
            DropPrimaryKey("dbo.PowerSupplyUnits");
            DropPrimaryKey("dbo.VideoCards");
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        ProjectId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                        Notes = c.String(),
                        MemoryId = c.Int(nullable: false),
                        CaseId = c.Int(nullable: false),
                        CoolerId = c.Int(nullable: false),
                        CpuId = c.Int(nullable: false),
                        VideoId = c.Int(nullable: false),
                        MotherboardId = c.Int(nullable: false),
                        PsuId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProjectId)
                .ForeignKey("dbo.Cases", t => t.CaseId, cascadeDelete: true)
                .ForeignKey("dbo.CPUs", t => t.CpuId, cascadeDelete: true)
                .ForeignKey("dbo.CPUCoolers", t => t.CoolerId, cascadeDelete: true)
                .ForeignKey("dbo.Memories", t => t.MemoryId, cascadeDelete: true)
                .ForeignKey("dbo.Motherboards", t => t.MotherboardId, cascadeDelete: true)
                .ForeignKey("dbo.PowerSupplyUnits", t => t.PsuId, cascadeDelete: true)
                .ForeignKey("dbo.VideoCards", t => t.VideoId, cascadeDelete: true)
                .Index(t => t.MemoryId)
                .Index(t => t.CaseId)
                .Index(t => t.CoolerId)
                .Index(t => t.CpuId)
                .Index(t => t.VideoId)
                .Index(t => t.MotherboardId)
                .Index(t => t.PsuId);
            
            DropColumn("dbo.Cases", "Id");
            DropColumn("dbo.CPUCoolers", "Id");
            DropColumn("dbo.CPUs", "Id");
            DropColumn("dbo.Storages", "Id");
            DropColumn("dbo.Memories", "Id");
            DropColumn("dbo.Motherboards", "Id");
            DropColumn("dbo.PowerSupplyUnits", "Id");
            DropColumn("dbo.VideoCards", "Id");
            AddColumn("dbo.Cases", "CaseId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.CPUCoolers", "CoolerId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.CPUs", "CpuId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Storages", "StorageId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Memories", "MemoryId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Motherboards", "MotherboardId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.PowerSupplyUnits", "PsuId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.VideoCards", "VideoId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Cases", "CaseId");
            AddPrimaryKey("dbo.CPUCoolers", "CoolerId");
            AddPrimaryKey("dbo.CPUs", "CpuId");
            AddPrimaryKey("dbo.Storages", "StorageId");
            AddPrimaryKey("dbo.Memories", "MemoryId");
            AddPrimaryKey("dbo.Motherboards", "MotherboardId");
            AddPrimaryKey("dbo.PowerSupplyUnits", "PsuId");
            AddPrimaryKey("dbo.VideoCards", "VideoId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.VideoCards", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.PowerSupplyUnits", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Motherboards", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Memories", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Storages", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.CPUs", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.CPUCoolers", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Cases", "Id", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.Projects", "VideoId", "dbo.VideoCards");
            DropForeignKey("dbo.Projects", "PsuId", "dbo.PowerSupplyUnits");
            DropForeignKey("dbo.Projects", "MotherboardId", "dbo.Motherboards");
            DropForeignKey("dbo.Projects", "MemoryId", "dbo.Memories");
            DropForeignKey("dbo.Projects", "CoolerId", "dbo.CPUCoolers");
            DropForeignKey("dbo.Projects", "CpuId", "dbo.CPUs");
            DropForeignKey("dbo.Projects", "CaseId", "dbo.Cases");
            DropIndex("dbo.Projects", new[] { "PsuId" });
            DropIndex("dbo.Projects", new[] { "MotherboardId" });
            DropIndex("dbo.Projects", new[] { "VideoId" });
            DropIndex("dbo.Projects", new[] { "CpuId" });
            DropIndex("dbo.Projects", new[] { "CoolerId" });
            DropIndex("dbo.Projects", new[] { "CaseId" });
            DropIndex("dbo.Projects", new[] { "MemoryId" });
            DropPrimaryKey("dbo.VideoCards");
            DropPrimaryKey("dbo.PowerSupplyUnits");
            DropPrimaryKey("dbo.Motherboards");
            DropPrimaryKey("dbo.Memories");
            DropPrimaryKey("dbo.Storages");
            DropPrimaryKey("dbo.CPUs");
            DropPrimaryKey("dbo.CPUCoolers");
            DropPrimaryKey("dbo.Cases");
            DropColumn("dbo.VideoCards", "VideoId");
            DropColumn("dbo.PowerSupplyUnits", "PsuId");
            DropColumn("dbo.Motherboards", "MotherboardId");
            DropColumn("dbo.Memories", "MemoryId");
            DropColumn("dbo.Storages", "StorageId");
            DropColumn("dbo.CPUs", "CpuId");
            DropColumn("dbo.CPUCoolers", "CoolerId");
            DropColumn("dbo.Cases", "CaseId");
            DropTable("dbo.Projects");
            AddPrimaryKey("dbo.VideoCards", "Id");
            AddPrimaryKey("dbo.PowerSupplyUnits", "Id");
            AddPrimaryKey("dbo.Motherboards", "Id");
            AddPrimaryKey("dbo.Memories", "Id");
            AddPrimaryKey("dbo.Storages", "Id");
            AddPrimaryKey("dbo.CPUs", "Id");
            AddPrimaryKey("dbo.CPUCoolers", "Id");
            AddPrimaryKey("dbo.Cases", "Id");
            AddForeignKey("dbo.Projects", "VideoId", "dbo.VideoCards", "VideoId", cascadeDelete: true);
            AddForeignKey("dbo.Projects", "PsuId", "dbo.PowerSupplyUnits", "PsuId", cascadeDelete: true);
            AddForeignKey("dbo.Projects", "MotherboardId", "dbo.Motherboards", "MotherboardId", cascadeDelete: true);
            AddForeignKey("dbo.Projects", "MemoryId", "dbo.Memories", "MemoryId", cascadeDelete: true);
            AddForeignKey("dbo.Projects", "CpuId", "dbo.CPUs", "CpuId", cascadeDelete: true);
            AddForeignKey("dbo.Projects", "CoolerId", "dbo.CPUCoolers", "CoolerId", cascadeDelete: true);
            AddForeignKey("dbo.Projects", "CaseId", "dbo.Cases", "CaseId", cascadeDelete: true);
        }
    }
}
