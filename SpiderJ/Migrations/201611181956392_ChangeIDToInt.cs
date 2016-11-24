namespace SpiderJ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeIDToInt : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Products");
            AlterColumn("dbo.Products", "ID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Products", "ID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Products");
            AlterColumn("dbo.Products", "ID", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Products", "ID");
        }
    }
}
