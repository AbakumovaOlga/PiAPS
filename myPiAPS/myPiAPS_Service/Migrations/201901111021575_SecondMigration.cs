namespace myPiAPS_Service.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Role", c => c.String());
            DropColumn("dbo.Users", "Pole");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Pole", c => c.String());
            DropColumn("dbo.Users", "Role");
        }
    }
}
