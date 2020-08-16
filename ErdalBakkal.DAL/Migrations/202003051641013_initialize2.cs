namespace ErdalBakkal.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialize2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Stock", c => c.Int(nullable: false));
            DropColumn("dbo.Products", "Stok");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Stok", c => c.Int(nullable: false));
            DropColumn("dbo.Products", "Stock");
        }
    }
}
