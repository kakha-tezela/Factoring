namespace FactoringService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedBussinessTypeIdToTranslationEntity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BussinessTypeTranslates", "BussinessTyeId_Id", c => c.Int());
            CreateIndex("dbo.BussinessTypeTranslates", "BussinessTyeId_Id");
            AddForeignKey("dbo.BussinessTypeTranslates", "BussinessTyeId_Id", "dbo.BussinessTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BussinessTypeTranslates", "BussinessTyeId_Id", "dbo.BussinessTypes");
            DropIndex("dbo.BussinessTypeTranslates", new[] { "BussinessTyeId_Id" });
            DropColumn("dbo.BussinessTypeTranslates", "BussinessTyeId_Id");
        }
    }
}
