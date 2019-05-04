namespace EntityFramework.Lab2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateRelationUserActivity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserActivities",
                c => new
                    {
                        Act_Id = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Act_Id)
                .ForeignKey("dbo.User", t => t.Act_Id)
                .Index(t => t.Act_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserActivities", "Act_Id", "dbo.User");
            DropIndex("dbo.UserActivities", new[] { "Act_Id" });
            DropTable("dbo.UserActivities");
        }
    }
}
