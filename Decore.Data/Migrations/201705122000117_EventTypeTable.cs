namespace Decore.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EventTypeTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "EventTypeId", c => c.Int(nullable: false));
            DropColumn("dbo.Events", "EventType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Events", "EventType", c => c.String(nullable: false));
            DropColumn("dbo.Events", "EventTypeId");
        }
    }
}
