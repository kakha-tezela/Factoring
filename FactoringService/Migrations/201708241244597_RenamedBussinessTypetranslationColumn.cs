namespace FactoringService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenamedBussinessTypetranslationColumn : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.BussinessTypeTranslates", name: "BussinessTyeId_Id", newName: "BussinessType_Id");
            RenameIndex(table: "dbo.BussinessTypeTranslates", name: "IX_BussinessTyeId_Id", newName: "IX_BussinessType_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.BussinessTypeTranslates", name: "IX_BussinessType_Id", newName: "IX_BussinessTyeId_Id");
            RenameColumn(table: "dbo.BussinessTypeTranslates", name: "BussinessType_Id", newName: "BussinessTyeId_Id");
        }
    }
}
