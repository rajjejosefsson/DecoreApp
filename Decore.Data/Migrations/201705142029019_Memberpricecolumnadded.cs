namespace Decore.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Memberpricecolumnadded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "MemberPrice", c => c.Single());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Events", "MemberPrice");
        }
    }
}
