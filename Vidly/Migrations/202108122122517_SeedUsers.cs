namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'1da3ad81-af9e-45cf-9627-9f51122f77bf', N'bp.naoe@gmail.com', 0, N'AEsrCSx8/lU9JsRyQ5w4SGlR7QWu4hfXNoUFuddQIkW8FmM1peSuqRpNbmQk8/aoIA==', N'218477a9-23fd-4370-a471-06d5d33838af', NULL, 0, 0, NULL, 1, 0, N'bp.naoe@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a0473842-68a9-4a64-806d-6e2b43b9fec6', N'guest@vidly.com', 0, N'AFrsdOFuW0GWP/pmGNyV2LXIcCHQAJhBae7t1kkB8S+qPkgpumumnJ+hN8u3BYVHxw==', N'7d24b535-3a05-43cc-8275-93e6c1a3bb92', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e157dd83-c6c6-4547-943b-ffc2e29732eb', N'admin@vidly.com', 0, N'ADCQhOLqIT7sTyNSqLZRyWqTpGjnWNZihRX/4oJKb/JGb3auY+KVWIDqvZfs1nEDTA==', N'8d9099e8-a98e-4f89-9136-d7cecf953307', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'b1548cb6-1528-4692-a968-e3ee17de8f35', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e157dd83-c6c6-4547-943b-ffc2e29732eb', N'b1548cb6-1528-4692-a968-e3ee17de8f35')

");
        }
        
        public override void Down()
        {
        }
    }
}
