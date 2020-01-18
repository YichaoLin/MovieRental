namespace Codly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ad8387b0-929c-49e8-b31d-432277505dc0', N'admin@codly.com', 0, N'AIqq5c+sAlPZW2krFuLfiYavIWQvkRgKN1a77AwbkjLTKwwwFkkuf55dk5t+DWi51Q==', N'9bc87ec2-4038-466c-8bc4-9345ed264443', NULL, 0, 0, NULL, 1, 0, N'admin@codly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e83afd10-4bd6-43fd-8ff6-015b1f5079ab', N'guest@codly.com', 0, N'ACEHSyo96i8PpvHEQsO6Ob3Y9qcUjdZSPvEeuHmMBp29sj3phoSwsHG1uVRCDOJw2g==', N'e87d7ca8-af72-48fc-b00b-72d7161d22c3', NULL, 0, 0, NULL, 1, 0, N'guest@codly.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'3a6240cf-141f-4a03-9c62-bdf140beff3e', N'CanManageMovie')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ad8387b0-929c-49e8-b31d-432277505dc0', N'3a6240cf-141f-4a03-9c62-bdf140beff3e')

");
        }
        
        public override void Down()
        {
        }
    }
}
