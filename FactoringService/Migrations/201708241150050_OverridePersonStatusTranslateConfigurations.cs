namespace FactoringService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OverridePersonStatusTranslateConfigurations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PersonStatusTranslates", "Language", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.PersonStatusTranslates", "Title", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PersonStatusTranslates", "Title", c => c.String());
            AlterColumn("dbo.PersonStatusTranslates", "Language", c => c.String());
        }
    }
}
