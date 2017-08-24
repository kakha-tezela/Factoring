namespace FactoringService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedSocialStatusToTranslationENtity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SocialStatusTranslates", "SocialStatus_Id", c => c.Int());
            CreateIndex("dbo.SocialStatusTranslates", "SocialStatus_Id");
            AddForeignKey("dbo.SocialStatusTranslates", "SocialStatus_Id", "dbo.SocialStatuses", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SocialStatusTranslates", "SocialStatus_Id", "dbo.SocialStatuses");
            DropIndex("dbo.SocialStatusTranslates", new[] { "SocialStatus_Id" });
            DropColumn("dbo.SocialStatusTranslates", "SocialStatus_Id");
        }
    }
}
