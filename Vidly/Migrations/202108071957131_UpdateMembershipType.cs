namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("Update MembershipTypes set Name ='Pay as You Go' where id = 1");
            Sql("Update MembershipTypes set Name ='Monthly' where id = 2");
            Sql("Update MembershipTypes set Name ='Quarterly' where id = 3");
            Sql("Update MembershipTypes set Name ='Yearly' where id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
