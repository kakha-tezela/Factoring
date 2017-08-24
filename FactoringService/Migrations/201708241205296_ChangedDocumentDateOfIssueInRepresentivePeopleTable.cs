namespace FactoringService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedDocumentDateOfIssueInRepresentivePeopleTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.RepresentivePeople", "DocumentDateOfIssue", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.RepresentivePeople", "DocumentDateOfIssue", c => c.String());
        }
    }
}
