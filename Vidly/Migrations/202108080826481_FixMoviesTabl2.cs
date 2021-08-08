namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixMoviesTabl2 : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Movies ON insert into Movies (id,Name,ReleaseDate,DateAdded,Stock,GenreTypeId) values (1,'Vivo','1/1/2021','5/1/2021',1,1) SET IDENTITY_INSERT Movies OFF");
            Sql("SET IDENTITY_INSERT Movies ON insert into Movies (id,Name,ReleaseDate,DateAdded,Stock,GenreTypeId) values (2,'Conjuring','1/2/2021','5/2/2021',5,3) SET IDENTITY_INSERT Movies OFF");
            Sql("SET IDENTITY_INSERT Movies ON insert into Movies (id,Name,ReleaseDate,DateAdded,Stock,GenreTypeId) values (3,'Patriot','1/3/2021','5/3/2021',4,2) SET IDENTITY_INSERT Movies OFF");
            Sql("SET IDENTITY_INSERT Movies ON insert into Movies (id,Name,ReleaseDate,DateAdded,Stock,GenreTypeId) values (4,'Human Nature','1/4/2021','5/4/2021',10,1) SET IDENTITY_INSERT Movies OFF");
            Sql("SET IDENTITY_INSERT Movies ON insert into Movies (id,Name,ReleaseDate,DateAdded,Stock,GenreTypeId) values (5,'Alien','1/10/2021','5/10/2021',7,5) SET IDENTITY_INSERT Movies OFF");
            Sql("SET IDENTITY_INSERT Movies ON insert into Movies (id,Name,ReleaseDate,DateAdded,Stock,GenreTypeId) values (6,'Life','1/11/2021','5/17/2021',6,4) SET IDENTITY_INSERT Movies OFF");
        }
        
        public override void Down()
        {
        }
    }
}
