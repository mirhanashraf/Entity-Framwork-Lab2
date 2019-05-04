namespace EntityFramework.Lab2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableUserCity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.User_City",
                c => new
                    {
                        U_Id = c.Int(nullable: false),
                        C_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.U_Id, t.C_Id })
                .ForeignKey("dbo.User", t => t.U_Id)
                .ForeignKey("dbo.City", t => t.C_Id)
                .Index(t => t.U_Id)
                .Index(t => t.C_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.User_City", "C_Id", "dbo.City");
            DropForeignKey("dbo.User_City", "U_Id", "dbo.User");
            DropIndex("dbo.User_City", new[] { "C_Id" });
            DropIndex("dbo.User_City", new[] { "U_Id" });
            DropTable("dbo.User_City");
        }
    }
}
