namespace FactoringService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedBussinessTypeIdToCompanyTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Companies", "BussinessTypeId_Id", c => c.Int());
            CreateIndex("dbo.Companies", "BussinessTypeId_Id");
            AddForeignKey("dbo.Companies", "BussinessTypeId_Id", "dbo.BussinessTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Companies", "BussinessTypeId_Id", "dbo.BussinessTypes");
            DropIndex("dbo.Companies", new[] { "BussinessTypeId_Id" });
            DropColumn("dbo.Companies", "BussinessTypeId_Id");
        }
    }
}
