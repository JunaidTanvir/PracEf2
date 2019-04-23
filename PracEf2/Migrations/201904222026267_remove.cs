namespace PracEf2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class remove : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Books", "PublisherId", "dbo.Publishers");
            DropIndex("dbo.Books", new[] { "PublisherId" });
            DropColumn("dbo.Books", "PublisherId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "PublisherId", c => c.Int(nullable: false));
            CreateIndex("dbo.Books", "PublisherId");
            AddForeignKey("dbo.Books", "PublisherId", "dbo.Publishers", "PublisherId", cascadeDelete: true);
        }
    }
}
