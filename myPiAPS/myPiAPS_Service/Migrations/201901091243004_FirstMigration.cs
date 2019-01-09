namespace myPiAPS_Service.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProdGroups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Norm = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Mark = c.String(),
                        Producer = c.String(),
                        Provider = c.String(),
                        Price = c.Double(),
                        AdvInf = c.String(),
                        ProdGroupId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProdGroups", t => t.ProdGroupId, cascadeDelete: true)
                .Index(t => t.ProdGroupId);
            
            CreateTable(
                "dbo.ProductWaybills",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Count = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        WaybillId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Waybills", t => t.WaybillId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.WaybillId);
            
            CreateTable(
                "dbo.Waybills",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Customer = c.String(),
                        Summa = c.Double(nullable: false),
                        Koef = c.Double(),
                        TypeOfWaybillId = c.Int(nullable: false),
                        ShopHallId = c.Int(nullable: false),
                        StockId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ShopHalls", t => t.ShopHallId, cascadeDelete: true)
                .ForeignKey("dbo.Stocks", t => t.StockId, cascadeDelete: true)
                .ForeignKey("dbo.TypeOfWaybills", t => t.TypeOfWaybillId, cascadeDelete: true)
                .Index(t => t.TypeOfWaybillId)
                .Index(t => t.ShopHallId)
                .Index(t => t.StockId);
            
            CreateTable(
                "dbo.ShopHalls",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FIO = c.String(),
                        Login = c.String(),
                        Password = c.String(),
                        Pole = c.String(),
                        ShopHallId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ShopHalls", t => t.ShopHallId)
                .Index(t => t.ShopHallId);
            
            CreateTable(
                "dbo.Stocks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TypeOfWaybills",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Waybills", "TypeOfWaybillId", "dbo.TypeOfWaybills");
            DropForeignKey("dbo.Waybills", "StockId", "dbo.Stocks");
            DropForeignKey("dbo.Waybills", "ShopHallId", "dbo.ShopHalls");
            DropForeignKey("dbo.Users", "ShopHallId", "dbo.ShopHalls");
            DropForeignKey("dbo.ProductWaybills", "WaybillId", "dbo.Waybills");
            DropForeignKey("dbo.ProductWaybills", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Products", "ProdGroupId", "dbo.ProdGroups");
            DropIndex("dbo.Users", new[] { "ShopHallId" });
            DropIndex("dbo.Waybills", new[] { "StockId" });
            DropIndex("dbo.Waybills", new[] { "ShopHallId" });
            DropIndex("dbo.Waybills", new[] { "TypeOfWaybillId" });
            DropIndex("dbo.ProductWaybills", new[] { "WaybillId" });
            DropIndex("dbo.ProductWaybills", new[] { "ProductId" });
            DropIndex("dbo.Products", new[] { "ProdGroupId" });
            DropTable("dbo.TypeOfWaybills");
            DropTable("dbo.Stocks");
            DropTable("dbo.Users");
            DropTable("dbo.ShopHalls");
            DropTable("dbo.Waybills");
            DropTable("dbo.ProductWaybills");
            DropTable("dbo.Products");
            DropTable("dbo.ProdGroups");
        }
    }
}
