namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingBirthdayFieldToCustomerTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "BirthdDate", c => c.DateTime(nullable: true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "BirthdDate");
        }
    }
}
