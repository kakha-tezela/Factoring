namespace FactoringService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletedCountriesTable : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Countries");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
