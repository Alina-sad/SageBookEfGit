namespace SageBookEfGit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Birthday = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SagesBooks",
                c => new
                    {
                        Sages_Id = c.Int(nullable: false),
                        Books_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Sages_Id, t.Books_Id })
                .ForeignKey("dbo.Sages", t => t.Sages_Id, cascadeDelete: true)
                .ForeignKey("dbo.Books", t => t.Books_Id, cascadeDelete: true)
                .Index(t => t.Sages_Id)
                .Index(t => t.Books_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SagesBooks", "Books_Id", "dbo.Books");
            DropForeignKey("dbo.SagesBooks", "Sages_Id", "dbo.Sages");
            DropIndex("dbo.SagesBooks", new[] { "Books_Id" });
            DropIndex("dbo.SagesBooks", new[] { "Sages_Id" });
            DropTable("dbo.SagesBooks");
            DropTable("dbo.Sages");
            DropTable("dbo.Books");
        }
    }
}
