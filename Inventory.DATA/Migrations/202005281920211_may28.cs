namespace Inventory.DATA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class may28 : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.OpticalDrives");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.OpticalDrives",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Manufacturer = c.String(nullable: false),
                        FormFactor = c.String(nullable: false),
                        Interface = c.String(nullable: false),
                        Capability = c.String(nullable: false),
                        Color = c.String(nullable: false),
                        BufferCache = c.Int(nullable: false),
                        IsAvailable = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
