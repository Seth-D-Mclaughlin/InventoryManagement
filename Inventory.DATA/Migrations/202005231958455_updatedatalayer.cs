namespace Inventory.DATA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedatalayer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.VideoCards", "Manufacturer", c => c.String(nullable: false));
            AddColumn("dbo.VideoCards", "IsAvailable", c => c.Boolean(nullable: false));
            DropColumn("dbo.VideoCards", "ExternalPower");
        }
        
        public override void Down()
        {
            AddColumn("dbo.VideoCards", "ExternalPower", c => c.String(nullable: false));
            DropColumn("dbo.VideoCards", "IsAvailable");
            DropColumn("dbo.VideoCards", "Manufacturer");
        }
    }
}
