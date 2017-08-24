namespace FactoringService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OverrideCountryTranslateConventions : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CountryTranslates", "Language", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.CountryTranslates", "Title", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CountryTranslates", "Title", c => c.String());
            AlterColumn("dbo.CountryTranslates", "Language", c => c.String());
        }
    }
}
