namespace Decore.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedcolumnBoughtAtinTickets : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tickets", "BoughtAt", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tickets", "BoughtAt");
        }
    }
}
