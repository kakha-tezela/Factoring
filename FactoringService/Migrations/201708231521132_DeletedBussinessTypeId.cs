namespace FactoringService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletedBussinessTypeId : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.BussinessTypeTranslates", "BussinessTypeId_Id", "dbo.BussinessTypes");
            DropIndex("dbo.BussinessTypeTranslates", new[] { "BussinessTypeId_Id" });
            DropColumn("dbo.BussinessTypeTranslates", "BussinessTypeId_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BussinessTypeTranslates", "BussinessTypeId_Id", c => c.Int());
            CreateIndex("dbo.BussinessTypeTranslates", "BussinessTypeId_Id");
            AddForeignKey("dbo.BussinessTypeTranslates", "BussinessTypeId_Id", "dbo.BussinessTypes", "Id");
        }
    }
}
