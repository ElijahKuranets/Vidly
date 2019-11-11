namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded,ReleaseDate,NumberInStock) VALUES ('A Love So Beautiful',3,2017-11-03, 2017-12-12,3)");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded,ReleaseDate,NumberInStock) VALUES ('Terminator',1,2014-12-03, 2019-12-12,5)");
        }
        
        public override void Down()
        {
        }
    }
}
