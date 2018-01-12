namespace LmsWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDefaultRoute : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetRoles", "Description", c => c.String(maxLength: 50));
            AddColumn("dbo.AspNetRoles", "DefaultRoute", c => c.String(maxLength: 20));
            AddColumn("dbo.AspNetRoles", "Discriminator", c => c.String(nullable: false, maxLength: 128));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetRoles", "Discriminator");
            DropColumn("dbo.AspNetRoles", "DefaultRoute");
            DropColumn("dbo.AspNetRoles", "Description");
        }
    }
}
