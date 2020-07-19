namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedBirthdateField : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "BirthdDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "BirthdDate", c => c.DateTime(nullable: false));
        }
    }
}
