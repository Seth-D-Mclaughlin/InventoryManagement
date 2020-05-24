namespace Inventory.DATA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class may25 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PowerSupplyUnits", "IsAvailable", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PowerSupplyUnits", "IsAvailable");
        }
    }
}
