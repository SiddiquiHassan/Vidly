namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatingGenreTable : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Genres values(1,'Comedy')");
            Sql("insert into Genres values(2,'Horror')");
            Sql("insert into Genres values(3,'Thriller')");
            Sql("insert into Genres values(4,'RomCom')");
            Sql("insert into Genres values(5,'Drama')");
            Sql("insert into Genres values(6,'Mystery')");
        }
        
        public override void Down()
        {
        }
    }
}
