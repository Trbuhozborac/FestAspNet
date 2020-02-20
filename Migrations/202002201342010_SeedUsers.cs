namespace FrogMusicFest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'bd62a7b7-f80b-4792-ad5d-146aa5e2cb84', N'user@gmail.com', 0, N'APKwrnEuemZqFyTzhAo5wUOY6++/lQYaL4QTguBMX82XEK2xq2CgBjfsTnvVwd3hIQ==', N'cc085682-023c-4038-93e6-0e96ceb6bf04', NULL, 0, 0, NULL, 1, 0, N'user@gmail.com')
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ee01149f-6079-4c1b-b5dd-ddaab91246e9', N'frogmusicfest@gmail.com', 0, N'ACG1HFPUWSxXwftV3sKSx8xc1s/5K7PwIhuSpYMM19FOXK1OyQ7VdMMPGJapT57KNg==', N'27f0ef46-bf05-48ab-b765-3096823b1deb', NULL, 0, 0, NULL, 1, 0, N'frogmusicfest@gmail.com')
                ");

            Sql(@"
                    INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'3b65e0ea-b676-4640-b83b-820986329c4c', N'AdminDodaje')

            ");
            Sql(@"
                    INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ee01149f-6079-4c1b-b5dd-ddaab91246e9', N'3b65e0ea-b676-4640-b83b-820986329c4c')
            ");

            
        }
        
        public override void Down()
        {
        }
    }
}
