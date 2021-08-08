namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovies1 : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Movies ON insert into Movies (Id,Name,ReleaseDate,DateAdded,Stock,GenreType_Id,GenreTypeId) values (1,'Vivo','1/2/2021','5/1/2021',5,1,1) SET IDENTITY_INSERT Movies OFF");
            Sql("SET IDENTITY_INSERT Movies ON insert into Movies (Id,Name,ReleaseDate,DateAdded,Stock,GenreType_Id,GenreTypeId) values (2,'Conjuring','1/3/2021','5/2/2021',6,3,3) SET IDENTITY_INSERT Movies OFF");
            Sql("SET IDENTITY_INSERT Movies ON insert into Movies (Id,Name,ReleaseDate,DateAdded,Stock,GenreType_Id,GenreTypeId) values (3,'Die Hard','1/4/2021','5/3/2021',4,2,2) SET IDENTITY_INSERT Movies OFF");
            Sql("SET IDENTITY_INSERT Movies ON insert into Movies (Id,Name,ReleaseDate,DateAdded,Stock,GenreType_Id,GenreTypeId) values (4,'Human Nature','1/6/2021','5/6/2021',3,1,1) SET IDENTITY_INSERT Movies OFF");
            Sql("SET IDENTITY_INSERT Movies ON insert into Movies (Id,Name,ReleaseDate,DateAdded,Stock,GenreType_Id,GenreTypeId) values (5,'Alien','1/4/2021','5/3/2021',10,5,5) SET IDENTITY_INSERT Movies OFF");
            Sql("SET IDENTITY_INSERT Movies ON insert into Movies (Id,Name,ReleaseDate,DateAdded,Stock,GenreType_Id,GenreTypeId) values (6,'Patriot','1/10/2021','5/17/2021',10,4,4) SET IDENTITY_INSERT Movies OFF");

        }
        
        public override void Down()
        {
        }
    }
}
