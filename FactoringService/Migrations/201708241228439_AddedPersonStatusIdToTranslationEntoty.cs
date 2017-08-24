namespace FactoringService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPersonStatusIdToTranslationEntoty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PersonStatusTranslates", "PersonStatusId_Id", c => c.Int());
            CreateIndex("dbo.PersonStatusTranslates", "PersonStatusId_Id");
            AddForeignKey("dbo.PersonStatusTranslates", "PersonStatusId_Id", "dbo.PersonStatuses", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PersonStatusTranslates", "PersonStatusId_Id", "dbo.PersonStatuses");
            DropIndex("dbo.PersonStatusTranslates", new[] { "PersonStatusId_Id" });
            DropColumn("dbo.PersonStatusTranslates", "PersonStatusId_Id");
        }
    }
}
