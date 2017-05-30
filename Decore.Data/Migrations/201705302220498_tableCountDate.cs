namespace Decore.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tableCountDate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CountDateTimes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CountTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CountDateTimes");
        }
    }
}
