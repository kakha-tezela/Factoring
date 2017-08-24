namespace FactoringService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletedBusinesstypeTable : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.BussinessTypes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.BussinessTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
