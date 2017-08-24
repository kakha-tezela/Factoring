namespace FactoringService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OverrideRepresentivePeopleConfigurations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.RepresentivePeople", "Firstname", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.RepresentivePeople", "Lastname", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.RepresentivePeople", "PersonalId", c => c.String(nullable: false, maxLength: 11));
            AlterColumn("dbo.RepresentivePeople", "PhysicalAddress", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.RepresentivePeople", "RegistrationAddress", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.RepresentivePeople", "DocumentNumber", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.RepresentivePeople", "DocumentRegisteringOrganization", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.RepresentivePeople", "PersonRegistrationCode", c => c.String(maxLength: 255));
            AlterColumn("dbo.RepresentivePeople", "PersonRegisteringOrganization", c => c.String(maxLength: 255));
            AlterColumn("dbo.RepresentivePeople", "PersonPosition", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.RepresentivePeople", "PersonPosition", c => c.String());
            AlterColumn("dbo.RepresentivePeople", "PersonRegisteringOrganization", c => c.String());
            AlterColumn("dbo.RepresentivePeople", "PersonRegistrationCode", c => c.String());
            AlterColumn("dbo.RepresentivePeople", "DocumentRegisteringOrganization", c => c.String());
            AlterColumn("dbo.RepresentivePeople", "DocumentNumber", c => c.String());
            AlterColumn("dbo.RepresentivePeople", "RegistrationAddress", c => c.String());
            AlterColumn("dbo.RepresentivePeople", "PhysicalAddress", c => c.String());
            AlterColumn("dbo.RepresentivePeople", "PersonalId", c => c.String());
            AlterColumn("dbo.RepresentivePeople", "Lastname", c => c.String());
            AlterColumn("dbo.RepresentivePeople", "Firstname", c => c.String());
        }
    }
}
