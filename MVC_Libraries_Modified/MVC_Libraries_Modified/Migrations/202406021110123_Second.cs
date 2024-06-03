namespace MVC_Libraries_Modified.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Second : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        BookCode = c.String(nullable: false, maxLength: 5),
                        AuthorId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Authors", t => t.AuthorId)
                .Index(t => t.AuthorId);
            
            CreateTable(
                "dbo.Libraries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Location = c.String(),
                        ImageURL = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LibraryBooks",
                c => new
                    {
                        Library_Id = c.Int(nullable: false),
                        Book_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Library_Id, t.Book_Id })
                .ForeignKey("dbo.Libraries", t => t.Library_Id, cascadeDelete: true)
                .ForeignKey("dbo.Books", t => t.Book_Id, cascadeDelete: true)
                .Index(t => t.Library_Id)
                .Index(t => t.Book_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LibraryBooks", "Book_Id", "dbo.Books");
            DropForeignKey("dbo.LibraryBooks", "Library_Id", "dbo.Libraries");
            DropForeignKey("dbo.Books", "AuthorId", "dbo.Authors");
            DropIndex("dbo.LibraryBooks", new[] { "Book_Id" });
            DropIndex("dbo.LibraryBooks", new[] { "Library_Id" });
            DropIndex("dbo.Books", new[] { "AuthorId" });
            DropTable("dbo.LibraryBooks");
            DropTable("dbo.Libraries");
            DropTable("dbo.Books");
            DropTable("dbo.Authors");
        }
    }
}
