namespace FactoringService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OverrideConventions2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Companies", "Email", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Companies", "Email", c => c.String());
        }
    }
}
