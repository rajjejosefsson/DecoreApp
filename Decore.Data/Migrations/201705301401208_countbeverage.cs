namespace Decore.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class countbeverage : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CountBeverages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CountTime = c.DateTime(nullable: false),
                        BeverageId = c.Int(nullable: false),
                        Amount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CountBeverages");
        }
    }
}
