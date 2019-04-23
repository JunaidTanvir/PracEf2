namespace PracEf2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class t3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "RollNo", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "RollNo");
        }
    }
}
