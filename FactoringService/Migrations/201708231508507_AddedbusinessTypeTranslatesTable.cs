namespace FactoringService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedbusinessTypeTranslatesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BussinessTypeTranslates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Language = c.String(),
                        Title = c.String(),
                        BussinessTypeId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BussinessTypes", t => t.BussinessTypeId_Id)
                .Index(t => t.BussinessTypeId_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BussinessTypeTranslates", "BussinessTypeId_Id", "dbo.BussinessTypes");
            DropIndex("dbo.BussinessTypeTranslates", new[] { "BussinessTypeId_Id" });
            DropTable("dbo.BussinessTypeTranslates");
        }
    }
}
