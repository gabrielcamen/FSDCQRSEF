namespace SweetShop.DataAcces.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAndChangedModels : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cakes", "Price", c => c.Double(nullable: false));
            DropColumn("dbo.Cakes", "Description");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cakes", "Description", c => c.String());
            DropColumn("dbo.Cakes", "Price");
        }
    }
}
