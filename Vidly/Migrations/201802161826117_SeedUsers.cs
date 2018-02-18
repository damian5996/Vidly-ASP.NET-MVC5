namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'6b0b2885-0cae-48d4-9804-1b87dccb437a', N'admin@vidly.com', 0, N'AMWfxuSjbQR0dcgOVcoJfwB2HqAYsiHPdDQ3lBQJgzsnZH1f5GsNALAUKge1fZlHFw==', N'f5b58489-aab2-44dd-8cfc-13e906336946', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'6f0021b6-d627-4ed7-b50b-b880c7b91941', N'damian5996@wp.pl', 0, N'ABVd2f/PwXn3pVqcsqit3m05qe/bHND05N371yyd21qW+TRaKxy8spLwr7aPTc+xkw==', N'47dda64f-7fcc-40bc-83a8-a5acba7b721e', NULL, 0, 0, NULL, 1, 0, N'damian5996@wp.pl')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'd4895b44-2342-4808-a996-4c8cc2144eb4', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'6b0b2885-0cae-48d4-9804-1b87dccb437a', N'd4895b44-2342-4808-a996-4c8cc2144eb4')

");
        }
        
        public override void Down()
        {
        }
    }
}
