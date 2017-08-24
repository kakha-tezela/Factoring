namespace FactoringService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OverrideDocumentTypeConfigurations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.DocumentTypeTranslates", "Language", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.DocumentTypeTranslates", "Title", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.DocumentTypeTranslates", "Title", c => c.String());
            AlterColumn("dbo.DocumentTypeTranslates", "Language", c => c.String());
        }
    }
}
