namespace FactoringService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletedUsersTable : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Users");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Firstname = c.String(nullable: false, maxLength: 255),
                        Lastname = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
