namespace FactoringService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCompaniesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        PhoneNumber = c.String(),
                        Email = c.String(),
                        CompanyCode = c.String(),
                        RegistrationDate = c.DateTime(nullable: false),
                        RegistrationAddress = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                        Salt = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Companies");
        }
    }
}
