namespace FactoringService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OverrideBussinessTypeTranslateConventions1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.BussinessTypeTranslates", "Language", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.BussinessTypeTranslates", "Title", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.BussinessTypeTranslates", "Title", c => c.String());
            AlterColumn("dbo.BussinessTypeTranslates", "Language", c => c.String());
        }
    }
}
