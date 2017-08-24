namespace FactoringService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedSocialStatusTranslateTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SocialStatusTranslates",
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
            DropTable("dbo.SocialStatusTranslates");
        }
    }
}
