namespace PracEf2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class s2AddMany2Many : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PublisherBooks",
                c => new
                    {
                        Publisher_PublisherId = c.Int(nullable: false),
                        Book_BookId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Publisher_PublisherId, t.Book_BookId })
                .ForeignKey("dbo.Publishers", t => t.Publisher_PublisherId, cascadeDelete: true)
                .ForeignKey("dbo.Books", t => t.Book_BookId, cascadeDelete: true)
                .Index(t => t.Publisher_PublisherId)
                .Index(t => t.Book_BookId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PublisherBooks", "Book_BookId", "dbo.Books");
            DropForeignKey("dbo.PublisherBooks", "Publisher_PublisherId", "dbo.Publishers");
            DropIndex("dbo.PublisherBooks", new[] { "Book_BookId" });
            DropIndex("dbo.PublisherBooks", new[] { "Publisher_PublisherId" });
            DropTable("dbo.PublisherBooks");
        }
    }
}
