namespace EntityFramework.Lab2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyCountryCity : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Cities", newName: "City");
            RenameTable(name: "dbo.Countries", newName: "Country");
            AlterColumn("dbo.City", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Country", "Name", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Country", "Name", c => c.String());
            AlterColumn("dbo.City", "Name", c => c.String());
            RenameTable(name: "dbo.Country", newName: "Countries");
            RenameTable(name: "dbo.City", newName: "Cities");
        }
    }
}
