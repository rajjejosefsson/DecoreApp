namespace Decore.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EventTypeTableAddedNow : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EventTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EventTypes");
        }
    }
}
