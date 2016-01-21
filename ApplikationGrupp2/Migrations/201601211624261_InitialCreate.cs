namespace ApplikationGrupp2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 30),
                        LastName = c.String(nullable: false, maxLength: 30),
                        Email = c.String(nullable: false, maxLength: 50),
                        PhoneNumber = c.String(nullable: false, maxLength: 30, unicode: false),
                    })
                .PrimaryKey(t => t.CustomerID);
            
            CreateTable(
                "dbo.OrderItem",
                c => new
                    {
                        OrderItemID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.OrderItemID);
            
            CreateTable(
                "dbo.Order",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        CustomerID_CustomerID = c.Int(),
                    })
                .PrimaryKey(t => t.OrderID)
                .ForeignKey("dbo.Customer", t => t.CustomerID_CustomerID)
                .Index(t => t.CustomerID_CustomerID);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ProductID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 30),
                        LastName = c.String(nullable: false, maxLength: 30),
                        Email = c.String(nullable: false, maxLength: 50),
                        UserName = c.String(nullable: false, maxLength: 50, unicode: false),
                        Password = c.String(nullable: false, maxLength: 12, unicode: false),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Order", "CustomerID_CustomerID", "dbo.Customer");
            DropIndex("dbo.Order", new[] { "CustomerID_CustomerID" });
            DropTable("dbo.Users");
            DropTable("dbo.Product");
            DropTable("dbo.Order");
            DropTable("dbo.OrderItem");
            DropTable("dbo.Customer");
        }
    }
}
