using System.Diagnostics.PerformanceData;

namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenres : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT GenreTypes ON insert into GenreTypes (Id, Name) values (1,'Family') SET IDENTITY_INSERT GenreTypes OFF");
            Sql("SET IDENTITY_INSERT GenreTypes ON insert into GenreTypes (Id, Name) values (2,'Action') SET IDENTITY_INSERT GenreTypes OFF");
            Sql("SET IDENTITY_INSERT GenreTypes ON insert into GenreTypes (Id, Name) values (3,'Suspense') SET IDENTITY_INSERT GenreTypes OFF");
            Sql("SET IDENTITY_INSERT GenreTypes ON insert into GenreTypes (Id, Name) values (4,'Drama') SET IDENTITY_INSERT GenreTypes OFF");
            Sql("SET IDENTITY_INSERT GenreTypes ON insert into GenreTypes (Id, Name) values (5,'Sci-Fi') SET IDENTITY_INSERT GenreTypes OFF");
        }
        
        public override void Down()
        {
        }
    }
}
