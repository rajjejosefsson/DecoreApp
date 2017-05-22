namespace Decore.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedMaxTicketsandMaxEmployees : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "MaxTickets", c => c.Int(nullable: false));
            AddColumn("dbo.Events", "MaxEmployees", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Events", "MaxEmployees");
            DropColumn("dbo.Events", "MaxTickets");
        }
    }
}
