namespace FactoringService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedRepresentivePeopleTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RepresentivePeople",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Firstname = c.String(),
                        Lastname = c.String(),
                        PersonalId = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        PhysicalAddress = c.String(),
                        RegistrationAddress = c.String(),
                        DocumentNumber = c.String(),
                        DocumentDateOfIssue = c.String(),
                        DocumentRegisteringOrganization = c.String(),
                        DocumentExpirationDate = c.DateTime(nullable: false),
                        PoliticPerson = c.Int(nullable: false),
                        PersonRegistrationDate = c.DateTime(nullable: false),
                        PersonRegistrationCode = c.String(),
                        PersonRegisteringOrganization = c.String(),
                        PersonPosition = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RepresentivePeople");
        }
    }
}
