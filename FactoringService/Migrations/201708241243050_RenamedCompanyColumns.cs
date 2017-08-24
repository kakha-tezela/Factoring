namespace FactoringService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenamedCompanyColumns : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Companies", name: "BussinessTypeId_Id", newName: "BussinessType_Id");
            RenameColumn(table: "dbo.Companies", name: "RepresentivePersonId_Id", newName: "RepresentivePerson_Id");
            RenameIndex(table: "dbo.Companies", name: "IX_BussinessTypeId_Id", newName: "IX_BussinessType_Id");
            RenameIndex(table: "dbo.Companies", name: "IX_RepresentivePersonId_Id", newName: "IX_RepresentivePerson_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Companies", name: "IX_RepresentivePerson_Id", newName: "IX_RepresentivePersonId_Id");
            RenameIndex(table: "dbo.Companies", name: "IX_BussinessType_Id", newName: "IX_BussinessTypeId_Id");
            RenameColumn(table: "dbo.Companies", name: "RepresentivePerson_Id", newName: "RepresentivePersonId_Id");
            RenameColumn(table: "dbo.Companies", name: "BussinessType_Id", newName: "BussinessTypeId_Id");
        }
    }
}
