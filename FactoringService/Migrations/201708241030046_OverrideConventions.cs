namespace FactoringService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OverrideConventions : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Companies", "Username", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Companies", "Password", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Companies", "Salt", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Companies", "Salt", c => c.String());
            AlterColumn("dbo.Companies", "Password", c => c.String());
            AlterColumn("dbo.Companies", "Username", c => c.String());
        }
    }
}
