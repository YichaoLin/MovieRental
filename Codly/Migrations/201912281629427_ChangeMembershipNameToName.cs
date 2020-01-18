namespace Codly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeMembershipNameToName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "Name", c => c.String());
            DropColumn("dbo.MembershipTypes", "MembershipName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MembershipTypes", "MembershipName", c => c.String());
            DropColumn("dbo.MembershipTypes", "Name");
        }
    }
}
