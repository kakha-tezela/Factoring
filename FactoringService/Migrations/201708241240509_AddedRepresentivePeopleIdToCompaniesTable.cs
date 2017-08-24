namespace FactoringService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedRepresentivePeopleIdToCompaniesTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Companies", "RepresentivePersonId_Id", c => c.Int());
            CreateIndex("dbo.Companies", "RepresentivePersonId_Id");
            AddForeignKey("dbo.Companies", "RepresentivePersonId_Id", "dbo.RepresentivePeople", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Companies", "RepresentivePersonId_Id", "dbo.RepresentivePeople");
            DropIndex("dbo.Companies", new[] { "RepresentivePersonId_Id" });
            DropColumn("dbo.Companies", "RepresentivePersonId_Id");
        }
    }
}
