namespace EntityFramework.Lab2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableBookRelation : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Book");
            AlterColumn("dbo.Book", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Book", "Id");
            CreateIndex("dbo.Book", "Id");
            AddForeignKey("dbo.Book", "Id", "dbo.City", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Book", "Id", "dbo.City");
            DropIndex("dbo.Book", new[] { "Id" });
            DropPrimaryKey("dbo.Book");
            AlterColumn("dbo.Book", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Book", "Id");
        }
    }
}
