namespace Inventory.DATA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class June3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Projects", "CaseId", "dbo.Cases");
            DropIndex("dbo.Projects", new[] { "CaseId" });
            AlterColumn("dbo.Projects", "CaseId", c => c.Int());
            CreateIndex("dbo.Projects", "CaseId");
            AddForeignKey("dbo.Projects", "CaseId", "dbo.Cases", "CaseId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Projects", "CaseId", "dbo.Cases");
            DropIndex("dbo.Projects", new[] { "CaseId" });
            AlterColumn("dbo.Projects", "CaseId", c => c.Int(nullable: false));
            CreateIndex("dbo.Projects", "CaseId");
            AddForeignKey("dbo.Projects", "CaseId", "dbo.Cases", "CaseId", cascadeDelete: true);
        }
    }
}
