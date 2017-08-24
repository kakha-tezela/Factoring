namespace FactoringService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenamedPersonStatusColumn : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.PersonStatusTranslates", name: "PersonStatusId_Id", newName: "PersonStatus_Id");
            RenameIndex(table: "dbo.PersonStatusTranslates", name: "IX_PersonStatusId_Id", newName: "IX_PersonStatus_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.PersonStatusTranslates", name: "IX_PersonStatus_Id", newName: "IX_PersonStatusId_Id");
            RenameColumn(table: "dbo.PersonStatusTranslates", name: "PersonStatus_Id", newName: "PersonStatusId_Id");
        }
    }
}
