namespace FactoringService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCountryIdToTranslationEntity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CountryTranslates", "CountryId_Id", c => c.Int());
            CreateIndex("dbo.CountryTranslates", "CountryId_Id");
            AddForeignKey("dbo.CountryTranslates", "CountryId_Id", "dbo.Countries", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CountryTranslates", "CountryId_Id", "dbo.Countries");
            DropIndex("dbo.CountryTranslates", new[] { "CountryId_Id" });
            DropColumn("dbo.CountryTranslates", "CountryId_Id");
        }
    }
}
