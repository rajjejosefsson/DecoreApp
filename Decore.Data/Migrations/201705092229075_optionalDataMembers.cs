namespace Decore.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class optionalDataMembers : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Events", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.Events", "Description", c => c.String(nullable: false));
            AlterColumn("dbo.Events", "SaleStop", c => c.DateTime());
            AlterColumn("dbo.Events", "BasePrice", c => c.Single());
            AlterColumn("dbo.Events", "EventType", c => c.String(nullable: false));
            AlterColumn("dbo.Events", "ZipCode", c => c.String(nullable: false));
            AlterColumn("dbo.Events", "Adress", c => c.String(nullable: false));
            AlterColumn("dbo.Events", "UpdatedAt", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Events", "UpdatedAt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Events", "Adress", c => c.String());
            AlterColumn("dbo.Events", "ZipCode", c => c.String());
            AlterColumn("dbo.Events", "EventType", c => c.String());
            AlterColumn("dbo.Events", "BasePrice", c => c.Single(nullable: false));
            AlterColumn("dbo.Events", "SaleStop", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Events", "Description", c => c.String());
            AlterColumn("dbo.Events", "Title", c => c.String());
        }
    }
}
