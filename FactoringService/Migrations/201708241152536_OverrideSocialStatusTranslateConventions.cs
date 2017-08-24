namespace FactoringService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OverrideSocialStatusTranslateConventions : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SocialStatusTranslates", "Language", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.SocialStatusTranslates", "Title", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SocialStatusTranslates", "Title", c => c.String());
            AlterColumn("dbo.SocialStatusTranslates", "Language", c => c.String());
        }
    }
}
