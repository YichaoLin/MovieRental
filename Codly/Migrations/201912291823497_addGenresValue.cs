namespace Codly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addGenresValue : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres(Id,Name) VALUES(1,'Comedy')");
            //Sql("INSERT INTO MembershipTypes(Id,SignUpFee,DurationInMonths,Name,DiscountRate) VALUES(4,300,12,yearly,20)");
            Sql("INSERT INTO Genres(Id,Name) VALUES(22,'Action')");
            Sql("INSERT INTO Genres(Id,Name) VALUES(3,'Family')");
            Sql("INSERT INTO Genres(Id,Name) VALUES(4,'Romance')");
        }
        
        public override void Down()
        {
        }
    }
}
