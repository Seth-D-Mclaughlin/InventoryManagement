namespace Inventory.DATA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class may26 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OpticalDrives", "IsAvailable", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.OpticalDrives", "IsAvailable");
        }
    }
}
