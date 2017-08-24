namespace FactoringService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPersonStatusTranslatetable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PersonStatusTranslates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Language = c.String(),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PersonStatusTranslates");
        }
    }
}
