namespace FactoringService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakePersonRegistrationNullableINRepresentivePeople : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.RepresentivePeople", "PersonRegistrationDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.RepresentivePeople", "PersonRegistrationDate", c => c.DateTime(nullable: false));
        }
    }
}
