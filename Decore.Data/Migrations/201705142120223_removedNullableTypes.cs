namespace Decore.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removedNullableTypes : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Events", "SaleStop", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Events", "BasePrice", c => c.Single(nullable: false));
            AlterColumn("dbo.Events", "MemberPrice", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Events", "MemberPrice", c => c.Single());
            AlterColumn("dbo.Events", "BasePrice", c => c.Single());
            AlterColumn("dbo.Events", "SaleStop", c => c.DateTime());
        }
    }
}
