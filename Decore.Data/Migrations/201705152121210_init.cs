using System.Data.Entity.Migrations;

namespace Decore.Data.Migrations
{
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                    "dbo.Events",
                    c => new
                    {
                        Id = c.Int(false, true),
                        Title = c.String(false),
                        Description = c.String(false),
                        StartDate = c.DateTime(false),
                        EndDate = c.DateTime(false),
                        SaleStop = c.DateTime(false),
                        BasePrice = c.Single(false),
                        MemberPrice = c.Single(false),
                        EventTypeId = c.Int(false),
                        SectionId = c.Int(false),
                        ZipCode = c.String(false),
                        Adress = c.String(false),
                        ImageURL = c.String(),
                        EventOwner = c.Int(false),
                        CreatedBy = c.Int(false),
                        CreatedAt = c.DateTime(false),
                        UpdatedAt = c.DateTime()
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                    "dbo.EventTypes",
                    c => new
                    {
                        Id = c.Int(false, true),
                        Title = c.String()
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