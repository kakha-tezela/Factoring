namespace FactoringService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletedTitleFromBusinessType : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.BussinessTypes", "Title");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BussinessTypes", "Title", c => c.String());
        }
    }
}
