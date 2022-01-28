namespace SweetShop.DataAcces.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDbSets : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FeedBacks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cake_Id = c.Int(),
                        Client_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cakes", t => t.Cake_Id)
                .ForeignKey("dbo.Clients", t => t.Client_Id)
                .Index(t => t.Cake_Id)
                .Index(t => t.Client_Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Client_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.Client_Id)
                .Index(t => t.Client_Id);
            
            AddColumn("dbo.Cakes", "Order_Id", c => c.Int());
            CreateIndex("dbo.Cakes", "Order_Id");
            AddForeignKey("dbo.Cakes", "Order_Id", "dbo.Orders", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "Client_Id", "dbo.Clients");
            DropForeignKey("dbo.Cakes", "Order_Id", "dbo.Orders");
            DropForeignKey("dbo.FeedBacks", "Client_Id", "dbo.Clients");
            DropForeignKey("dbo.FeedBacks", "Cake_Id", "dbo.Cakes");
            DropIndex("dbo.Orders", new[] { "Client_Id" });
            DropIndex("dbo.FeedBacks", new[] { "Client_Id" });
            DropIndex("dbo.FeedBacks", new[] { "Cake_Id" });
            DropIndex("dbo.Cakes", new[] { "Order_Id" });
            DropColumn("dbo.Cakes", "Order_Id");
            DropTable("dbo.Orders");
            DropTable("dbo.FeedBacks");
        }
    }
}
