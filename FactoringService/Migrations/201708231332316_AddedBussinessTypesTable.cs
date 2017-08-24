namespace FactoringService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedBussinessTypesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BussinessTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BussinessTypes");
        }
    }
}
