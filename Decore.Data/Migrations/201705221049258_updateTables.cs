namespace Decore.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateTables : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tickets", "AmountOfTickets", c => c.Int(nullable: false));
            DropColumn("dbo.Tickets", "NumberOfTickets");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tickets", "NumberOfTickets", c => c.Int(nullable: false));
            DropColumn("dbo.Tickets", "AmountOfTickets");
        }
    }
}
