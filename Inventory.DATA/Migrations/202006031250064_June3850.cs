namespace Inventory.DATA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class June3850 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Projects", "CoolerId", "dbo.CPUCoolers");
            DropIndex("dbo.Projects", new[] { "CoolerId" });
            AlterColumn("dbo.Projects", "CoolerId", c => c.Int());
            CreateIndex("dbo.Projects", "CoolerId");
            AddForeignKey("dbo.Projects", "CoolerId", "dbo.CPUCoolers", "CoolerId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Projects", "CoolerId", "dbo.CPUCoolers");
            DropIndex("dbo.Projects", new[] { "CoolerId" });
            AlterColumn("dbo.Projects", "CoolerId", c => c.Int(nullable: false));
            CreateIndex("dbo.Projects", "CoolerId");
            AddForeignKey("dbo.Projects", "CoolerId", "dbo.CPUCoolers", "CoolerId", cascadeDelete: true);
        }
    }
}
