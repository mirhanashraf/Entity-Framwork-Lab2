namespace EntityFramework.Lab2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCountryCityRelationFluentApi : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.City", "CountryId", "dbo.Country");
            RenameColumn(table: "dbo.City", name: "CountryId", newName: "FK_CountryId");
            RenameIndex(table: "dbo.City", name: "IX_CountryId", newName: "IX_FK_CountryId");
            AddForeignKey("dbo.City", "FK_CountryId", "dbo.Country", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.City", "FK_CountryId", "dbo.Country");
            RenameIndex(table: "dbo.City", name: "IX_FK_CountryId", newName: "IX_CountryId");
            RenameColumn(table: "dbo.City", name: "FK_CountryId", newName: "CountryId");
            AddForeignKey("dbo.City", "CountryId", "dbo.Country", "Id", cascadeDelete: true);
        }
    }
}
