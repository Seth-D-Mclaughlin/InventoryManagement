namespace Inventory.DATA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Manufacturer = c.String(nullable: false),
                        Color = c.String(nullable: false),
                        PowerSupply = c.String(nullable: false),
                        Type = c.String(nullable: false),
                        SidePanelWindow = c.String(nullable: false),
                        PowerSupplyShroud = c.Boolean(nullable: false),
                        FrontPanelUSB = c.String(nullable: false),
                        MotherboardFormFactor = c.String(nullable: false),
                        External52Bay = c.Int(nullable: false),
                        External35Bay = c.Int(nullable: false),
                        Internal35Bay = c.Int(nullable: false),
                        Internal25Bay = c.Int(nullable: false),
                        FullHeightExpansionSlots = c.Int(),
                        HalfHeightExpansionSlots = c.Int(),
                        IsAvailable = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CPUCoolers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Manufacturer = c.String(nullable: false),
                        Color = c.String(nullable: false),
                        Height = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Bearing = c.String(nullable: false),
                        Socket = c.String(nullable: false),
                        WaterCooled = c.Boolean(nullable: false),
                        Fanless = c.Boolean(nullable: false),
                        IsAvailable = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CPUs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Manufacturer = c.String(nullable: false),
                        CoreCount = c.Int(nullable: false),
                        CoreClock = c.Single(nullable: false),
                        BoostClock = c.Single(nullable: false),
                        Series = c.String(nullable: false),
                        MicroArchitecture = c.String(nullable: false),
                        CoreFamily = c.String(nullable: false),
                        Socket = c.String(nullable: false),
                        IntegratedGraphics = c.Boolean(nullable: false),
                        SimultaneousMultithreading = c.Boolean(nullable: false),
                        IsAvailable = c.Boolean(nullable: false),
                        ThermalDesignPower = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Storages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Manufacturer = c.String(nullable: false),
                        IsAvailable = c.Boolean(nullable: false),
                        Interface = c.String(nullable: false),
                        Capacity = c.Int(nullable: false),
                        Type = c.String(nullable: false),
                        Color = c.String(),
                        IsPortiable = c.Boolean(),
                        FormFactor = c.String(),
                        NVME = c.Boolean(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Memories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Manufacturer = c.String(nullable: false),
                        Speed = c.String(nullable: false),
                        Type = c.String(nullable: false),
                        Modules = c.String(nullable: false),
                        CASLatency = c.Int(nullable: false),
                        Voltage = c.Single(nullable: false),
                        Timing = c.String(nullable: false),
                        HeatSpreader = c.Boolean(nullable: false),
                        IsAvailable = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Motherboards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Manufacturer = c.String(nullable: false),
                        Socket = c.String(nullable: false),
                        FormFactor = c.String(nullable: false),
                        MemoryMax = c.Int(nullable: false),
                        MemorySlots = c.Int(nullable: false),
                        Color = c.String(nullable: false),
                        Chipset = c.String(nullable: false),
                        PCIEX16Slots = c.Int(nullable: false),
                        PCIEX8Slots = c.Int(nullable: false),
                        PCIEX4Slots = c.Int(nullable: false),
                        PCISlots = c.Int(nullable: false),
                        EthernetPorts = c.Int(nullable: false),
                        M2Slots = c.Int(nullable: false),
                        Sata3GBsPorts = c.Int(nullable: false),
                        Sata6GBsPorts = c.Int(nullable: false),
                        SataExpressPorts = c.Int(nullable: false),
                        MSataSlots = c.Int(nullable: false),
                        OnboardVideo = c.Boolean(nullable: false),
                        OnboardUSB3Headers = c.Boolean(nullable: false),
                        WifiNetworking = c.Boolean(nullable: false),
                        IsAvailable = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
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
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PowerSupplyUnits",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Manufacturer = c.String(nullable: false),
                        EffeciencyRating = c.String(nullable: false),
                        TypeOfModular = c.Int(nullable: false),
                        Color = c.String(nullable: false),
                        Type = c.String(nullable: false),
                        Fanless = c.Boolean(nullable: false),
                        ATXConnectors = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.VideoCards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Chipset = c.String(nullable: false),
                        MemoryType = c.String(nullable: false),
                        CoreClock = c.Int(nullable: false),
                        BoostClock = c.Int(nullable: false),
                        SLICrossfire = c.String(nullable: false),
                        FrameSync = c.String(nullable: false),
                        Length = c.Int(nullable: false),
                        ThermalDesignPower = c.Int(nullable: false),
                        DVIPorts = c.Int(nullable: false),
                        HDMIPorts = c.Int(nullable: false),
                        MiniHDMIPorts = c.Int(nullable: false),
                        DisplayPorts = c.Int(nullable: false),
                        ExpansionSlotWidth = c.Int(nullable: false),
                        Cooling = c.String(nullable: false),
                        ExternalPower = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropTable("dbo.VideoCards");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.PowerSupplyUnits");
            DropTable("dbo.OpticalDrives");
            DropTable("dbo.Motherboards");
            DropTable("dbo.Memories");
            DropTable("dbo.Storages");
            DropTable("dbo.CPUs");
            DropTable("dbo.CPUCoolers");
            DropTable("dbo.Cases");
        }
    }
}
