namespace Decore.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sectionidadded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "SectionId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Events", "SectionId");
        }
    }
}
