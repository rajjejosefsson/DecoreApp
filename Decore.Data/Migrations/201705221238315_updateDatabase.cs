namespace Decore.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Beverages",
                c => new
                    {
                        BeverageId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Volume = c.Double(nullable: false),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.BeverageId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Beverages");
        }
    }
}
