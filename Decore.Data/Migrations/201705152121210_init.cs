namespace Decore.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        SaleStop = c.DateTime(nullable: false),
                        BasePrice = c.Single(nullable: false),
                        MemberPrice = c.Single(nullable: false),
                        EventTypeId = c.Int(nullable: false),
                        SectionId = c.Int(nullable: false),
                        ZipCode = c.String(nullable: false),
                        Adress = c.String(nullable: false),
                        ImageURL = c.String(),
                        EventOwner = c.Int(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
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
            DropTable("dbo.Events");
        }
    }
}
