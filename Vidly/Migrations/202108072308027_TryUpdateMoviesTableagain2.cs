namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TryUpdateMoviesTableagain2 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Movies", new[] { "GenreType_Id1" });
            DropColumn("dbo.Movies", "GenreType_Id");
            RenameColumn(table: "dbo.Movies", name: "GenreType_Id1", newName: "GenreType_Id");
            AddColumn("dbo.Movies", "GenreTypeId", c => c.Byte(nullable: false));
            AlterColumn("dbo.Movies", "GenreType_Id", c => c.Int());
            CreateIndex("dbo.Movies", "GenreType_Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Movies", new[] { "GenreType_Id" });
            AlterColumn("dbo.Movies", "GenreType_Id", c => c.Byte(nullable: false));
            DropColumn("dbo.Movies", "GenreTypeId");
            RenameColumn(table: "dbo.Movies", name: "GenreType_Id", newName: "GenreType_Id1");
            AddColumn("dbo.Movies", "GenreType_Id", c => c.Byte(nullable: false));
            CreateIndex("dbo.Movies", "GenreType_Id1");
        }
    }
}
