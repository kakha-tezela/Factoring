namespace FactoringService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OverrideCompaniesTableConventions : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Companies", "Title", c => c.String(nullable: false, maxLength: 350));
            AlterColumn("dbo.Companies", "PhoneNumber", c => c.String(nullable: false, maxLength: 9));
            AlterColumn("dbo.Companies", "CompanyCode", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Companies", "RegistrationAddress", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Companies", "RegistrationAddress", c => c.String());
            AlterColumn("dbo.Companies", "CompanyCode", c => c.String());
            AlterColumn("dbo.Companies", "PhoneNumber", c => c.String());
            AlterColumn("dbo.Companies", "Title", c => c.String());
        }
    }
}
