namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMoviesTable1 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Movies", "GenreTypeId");
            AddForeignKey("dbo.Movies", "GenreTypeId", "dbo.GenreTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {

        }
    }
}
