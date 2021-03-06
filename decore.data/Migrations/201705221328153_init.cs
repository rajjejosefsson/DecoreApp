namespace Decore.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Beverages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Percent = c.Single(nullable: false),
                        Price = c.Single(nullable: false),
                        IsAlcoholic = c.Boolean(nullable: false),
                        ImageURL = c.String(nullable: false),
                        Amount = c.Single(nullable: false),
                        UnitOfMeasure = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
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
                        MaxTickets = c.Int(nullable: false),
                        MaxEmployees = c.Int(nullable: false),
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
            
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BoughtAt = c.DateTime(nullable: false),
                        AmountOfTickets = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        EventId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tickets");
            DropTable("dbo.EventTypes");
            DropTable("dbo.Events");
            DropTable("dbo.Beverages");
        }
    }
}
