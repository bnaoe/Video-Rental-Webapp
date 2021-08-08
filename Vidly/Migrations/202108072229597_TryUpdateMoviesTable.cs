namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TryUpdateMoviesTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Movies", "GenreType_Id", "dbo.GenreTypes");
            DropIndex("dbo.Movies", new[] { "GenreType_Id" });
            AddColumn("dbo.Movies", "GenreType_Id1", c => c.Int());
            AlterColumn("dbo.Movies", "GenreType_Id", c => c.Byte(nullable: false));
            CreateIndex("dbo.Movies", "GenreType_Id1");
            AddForeignKey("dbo.Movies", "GenreType_Id1", "dbo.GenreTypes", "Id");
            DropColumn("dbo.Movies", "GenreTypeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "GenreTypeId", c => c.Byte(nullable: false));
            DropForeignKey("dbo.Movies", "GenreType_Id1", "dbo.GenreTypes");
            DropIndex("dbo.Movies", new[] { "GenreType_Id1" });
            AlterColumn("dbo.Movies", "GenreType_Id", c => c.Int());
            DropColumn("dbo.Movies", "GenreType_Id1");
            CreateIndex("dbo.Movies", "GenreType_Id");
            AddForeignKey("dbo.Movies", "GenreType_Id", "dbo.GenreTypes", "Id");
        }
    }
}
