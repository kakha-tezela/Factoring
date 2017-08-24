namespace FactoringService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedTitleFromCountries : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Countries", "Title");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Countries", "Title", c => c.String());
        }
    }
}
