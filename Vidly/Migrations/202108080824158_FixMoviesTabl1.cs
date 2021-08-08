namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixMoviesTabl1 : DbMigration
    {
        public override void Up()
        {
           
            AlterColumn("dbo.Movies", "GenreTypeId", c => c.Byte(nullable: false));

           
        }
        
        public override void Down()
        {
           
        }
    }
}
