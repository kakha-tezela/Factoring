namespace FactoringService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenamedDocumentTypeTableColumn : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.DocumentTypeTranslates", name: "DocumentTypeId_Id", newName: "DocumentType_Id");
            RenameIndex(table: "dbo.DocumentTypeTranslates", name: "IX_DocumentTypeId_Id", newName: "IX_DocumentType_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.DocumentTypeTranslates", name: "IX_DocumentType_Id", newName: "IX_DocumentTypeId_Id");
            RenameColumn(table: "dbo.DocumentTypeTranslates", name: "DocumentType_Id", newName: "DocumentTypeId_Id");
        }
    }
}
