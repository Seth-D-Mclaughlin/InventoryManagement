namespace Inventory.DATA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class June3929 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Projects", "CpuId", "dbo.CPUs");
            DropForeignKey("dbo.Projects", "MemoryId", "dbo.Memories");
            DropForeignKey("dbo.Projects", "MotherboardId", "dbo.Motherboards");
            DropForeignKey("dbo.Projects", "PsuId", "dbo.PowerSupplyUnits");
            DropForeignKey("dbo.Projects", "VideoId", "dbo.VideoCards");
            DropIndex("dbo.Projects", new[] { "MemoryId" });
            DropIndex("dbo.Projects", new[] { "CpuId" });
            DropIndex("dbo.Projects", new[] { "VideoId" });
            DropIndex("dbo.Projects", new[] { "MotherboardId" });
            DropIndex("dbo.Projects", new[] { "PsuId" });
            AlterColumn("dbo.Projects", "MemoryId", c => c.Int());
            AlterColumn("dbo.Projects", "CpuId", c => c.Int());
            AlterColumn("dbo.Projects", "VideoId", c => c.Int());
            AlterColumn("dbo.Projects", "MotherboardId", c => c.Int());
            AlterColumn("dbo.Projects", "PsuId", c => c.Int());
            CreateIndex("dbo.Projects", "MemoryId");
            CreateIndex("dbo.Projects", "CpuId");
            CreateIndex("dbo.Projects", "VideoId");
            CreateIndex("dbo.Projects", "MotherboardId");
            CreateIndex("dbo.Projects", "PsuId");
            AddForeignKey("dbo.Projects", "CpuId", "dbo.CPUs", "CpuId");
            AddForeignKey("dbo.Projects", "MemoryId", "dbo.Memories", "MemoryId");
            AddForeignKey("dbo.Projects", "MotherboardId", "dbo.Motherboards", "MotherboardId");
            AddForeignKey("dbo.Projects", "PsuId", "dbo.PowerSupplyUnits", "PsuId");
            AddForeignKey("dbo.Projects", "VideoId", "dbo.VideoCards", "VideoId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Projects", "VideoId", "dbo.VideoCards");
            DropForeignKey("dbo.Projects", "PsuId", "dbo.PowerSupplyUnits");
            DropForeignKey("dbo.Projects", "MotherboardId", "dbo.Motherboards");
            DropForeignKey("dbo.Projects", "MemoryId", "dbo.Memories");
            DropForeignKey("dbo.Projects", "CpuId", "dbo.CPUs");
            DropIndex("dbo.Projects", new[] { "PsuId" });
            DropIndex("dbo.Projects", new[] { "MotherboardId" });
            DropIndex("dbo.Projects", new[] { "VideoId" });
            DropIndex("dbo.Projects", new[] { "CpuId" });
            DropIndex("dbo.Projects", new[] { "MemoryId" });
            AlterColumn("dbo.Projects", "PsuId", c => c.Int(nullable: false));
            AlterColumn("dbo.Projects", "MotherboardId", c => c.Int(nullable: false));
            AlterColumn("dbo.Projects", "VideoId", c => c.Int(nullable: false));
            AlterColumn("dbo.Projects", "CpuId", c => c.Int(nullable: false));
            AlterColumn("dbo.Projects", "MemoryId", c => c.Int(nullable: false));
            CreateIndex("dbo.Projects", "PsuId");
            CreateIndex("dbo.Projects", "MotherboardId");
            CreateIndex("dbo.Projects", "VideoId");
            CreateIndex("dbo.Projects", "CpuId");
            CreateIndex("dbo.Projects", "MemoryId");
            AddForeignKey("dbo.Projects", "VideoId", "dbo.VideoCards", "VideoId", cascadeDelete: true);
            AddForeignKey("dbo.Projects", "PsuId", "dbo.PowerSupplyUnits", "PsuId", cascadeDelete: true);
            AddForeignKey("dbo.Projects", "MotherboardId", "dbo.Motherboards", "MotherboardId", cascadeDelete: true);
            AddForeignKey("dbo.Projects", "MemoryId", "dbo.Memories", "MemoryId", cascadeDelete: true);
            AddForeignKey("dbo.Projects", "CpuId", "dbo.CPUs", "CpuId", cascadeDelete: true);
        }
    }
}
