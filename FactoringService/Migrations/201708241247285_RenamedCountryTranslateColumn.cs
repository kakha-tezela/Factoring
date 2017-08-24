namespace FactoringService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenamedCountryTranslateColumn : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.CountryTranslates", name: "CountryId_Id", newName: "Country_Id");
            RenameIndex(table: "dbo.CountryTranslates", name: "IX_CountryId_Id", newName: "IX_Country_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.CountryTranslates", name: "IX_Country_Id", newName: "IX_CountryId_Id");
            RenameColumn(table: "dbo.CountryTranslates", name: "Country_Id", newName: "CountryId_Id");
        }
    }
}
