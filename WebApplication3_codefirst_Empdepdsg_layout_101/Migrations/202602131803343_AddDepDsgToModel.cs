namespace WebApplication3_codefirst_Empdepdsg_layout_101.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDepDsgToModel : DbMigration
    {
        public override void Up()
        {
            //Department
            Sql("INSERT INTO Departments VALUES ('Accounts')");
            Sql("INSERT INTO Departments VALUES ('Sales')");
            Sql("INSERT INTO Departments VALUES ('MKT')");
            Sql("INSERT INTO Departments VALUES ('Computers')");

            //Designation
            Sql("INSERT INTO Designations VALUES ('PM')");
            Sql("INSERT INTO Designations VALUES ('TL')");
            Sql("INSERT INTO Designations VALUES ('Programmer')");
        }

        public override void Down()
        {
        }
    }
}
