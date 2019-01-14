namespace myPiAPS_Service.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WBNotRequredIDS : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Waybills", "ShopHallId", "dbo.ShopHalls");
            DropForeignKey("dbo.Waybills", "StockId", "dbo.Stocks");
            DropForeignKey("dbo.Waybills", "TypeOfWaybillId", "dbo.TypeOfWaybills");
            DropIndex("dbo.Waybills", new[] { "TypeOfWaybillId" });
            DropIndex("dbo.Waybills", new[] { "ShopHallId" });
            DropIndex("dbo.Waybills", new[] { "StockId" });
            AlterColumn("dbo.Waybills", "TypeOfWaybillId", c => c.Int());
            AlterColumn("dbo.Waybills", "ShopHallId", c => c.Int());
            AlterColumn("dbo.Waybills", "StockId", c => c.Int());
            CreateIndex("dbo.Waybills", "TypeOfWaybillId");
            CreateIndex("dbo.Waybills", "ShopHallId");
            CreateIndex("dbo.Waybills", "StockId");
            AddForeignKey("dbo.Waybills", "ShopHallId", "dbo.ShopHalls", "Id");
            AddForeignKey("dbo.Waybills", "StockId", "dbo.Stocks", "Id");
            AddForeignKey("dbo.Waybills", "TypeOfWaybillId", "dbo.TypeOfWaybills", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Waybills", "TypeOfWaybillId", "dbo.TypeOfWaybills");
            DropForeignKey("dbo.Waybills", "StockId", "dbo.Stocks");
            DropForeignKey("dbo.Waybills", "ShopHallId", "dbo.ShopHalls");
            DropIndex("dbo.Waybills", new[] { "StockId" });
            DropIndex("dbo.Waybills", new[] { "ShopHallId" });
            DropIndex("dbo.Waybills", new[] { "TypeOfWaybillId" });
            AlterColumn("dbo.Waybills", "StockId", c => c.Int(nullable: false));
            AlterColumn("dbo.Waybills", "ShopHallId", c => c.Int(nullable: false));
            AlterColumn("dbo.Waybills", "TypeOfWaybillId", c => c.Int(nullable: false));
            CreateIndex("dbo.Waybills", "StockId");
            CreateIndex("dbo.Waybills", "ShopHallId");
            CreateIndex("dbo.Waybills", "TypeOfWaybillId");
            AddForeignKey("dbo.Waybills", "TypeOfWaybillId", "dbo.TypeOfWaybills", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Waybills", "StockId", "dbo.Stocks", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Waybills", "ShopHallId", "dbo.ShopHalls", "Id", cascadeDelete: true);
        }
    }
}
