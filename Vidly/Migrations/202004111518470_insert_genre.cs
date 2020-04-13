namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class insert_genre : DbMigration
    {
        public override void Up()
        {
            Sql("insert into genres (GenreName) values ('Drammar')");
            Sql("insert into genres (GenreName) values ('Thriller')");
            Sql("insert into genres (GenreName) values ('Romantic')");
        }
        
        public override void Down()
        {
        }
    }
}
