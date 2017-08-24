namespace FactoringService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDocumentTypeIdToTranslationEntity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DocumentTypeTranslates", "DocumentTypeId_Id", c => c.Int());
            CreateIndex("dbo.DocumentTypeTranslates", "DocumentTypeId_Id");
            AddForeignKey("dbo.DocumentTypeTranslates", "DocumentTypeId_Id", "dbo.DocumentTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DocumentTypeTranslates", "DocumentTypeId_Id", "dbo.DocumentTypes");
            DropIndex("dbo.DocumentTypeTranslates", new[] { "DocumentTypeId_Id" });
            DropColumn("dbo.DocumentTypeTranslates", "DocumentTypeId_Id");
        }
    }
}
