namespace FactoringService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSocialStatusesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SocialStatuses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SocialStatuses");
        }
    }
}
