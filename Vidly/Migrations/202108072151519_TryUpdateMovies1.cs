namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TryUpdateMovies1 : DbMigration
    {
        public override void Up()
        {
            Sql("alter table Movies drop column GenreType_Id");
        }
        
        public override void Down()
        {
        }
    }
}
