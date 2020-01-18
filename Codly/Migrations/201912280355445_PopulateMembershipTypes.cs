namespace Codly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes(Id,SignUpFee,DurationInMonths,Name,DiscountRate) VALUES(1,0,0,Pay as You Go,0)");
            Sql("INSERT INTO MembershipTypes(Id,SignUpFee,DurationInMonths,Name,DiscountRate) VALUES(2,30,1,Monthly,10)");
            Sql("INSERT INTO MembershipTypes(Id,SignUpFee,DurationInMonths,Name,DiscountRate) VALUES(3,90,3,quarterly,15)");
            Sql("INSERT INTO MembershipTypes(Id,SignUpFee,DurationInMonths,Name,DiscountRate) VALUES(4,300,12,yearly,20)");
        }

        public override void Down()
        {
        }
    }
}
