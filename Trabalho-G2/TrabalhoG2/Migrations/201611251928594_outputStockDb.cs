namespace TrabalhoG2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class outputStockDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.InputStocks",
                c => new
                    {
                        id_input_stock = c.Int(nullable: false, identity: true),
                        supplier = c.String(unicode: false),
                        entry_date = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.id_input_stock);
            
            CreateTable(
                "dbo.InputStockProducts",
                c => new
                    {
                        id_input_stock_product = c.Int(nullable: false, identity: true),
                        value = c.Double(nullable: false),
                        amount = c.Double(nullable: false),
                        input_stock_id_input_stock = c.Int(),
                        product_id_product = c.Int(),
                    })
                .PrimaryKey(t => t.id_input_stock_product)
                .ForeignKey("dbo.InputStocks", t => t.input_stock_id_input_stock)
                .ForeignKey("dbo.Products", t => t.product_id_product)
                .Index(t => t.input_stock_id_input_stock)
                .Index(t => t.product_id_product);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        id_product = c.Int(nullable: false, identity: true),
                        product_name = c.String(unicode: false),
                        amount = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.id_product);
            
            CreateTable(
                "dbo.OutputStocks",
                c => new
                    {
                        id_output_stock = c.Int(nullable: false, identity: true),
                        sector = c.String(unicode: false),
                        output_date = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.id_output_stock);
            
            CreateTable(
                "dbo.OutputStockProducts",
                c => new
                    {
                        id_output_stock_product = c.Int(nullable: false, identity: true),
                        value = c.Double(nullable: false),
                        amount = c.Double(nullable: false),
                        output_stock_id_output_stock = c.Int(),
                        product_id_product = c.Int(),
                    })
                .PrimaryKey(t => t.id_output_stock_product)
                .ForeignKey("dbo.OutputStocks", t => t.output_stock_id_output_stock)
                .ForeignKey("dbo.Products", t => t.product_id_product)
                .Index(t => t.output_stock_id_output_stock)
                .Index(t => t.product_id_product);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OutputStockProducts", "product_id_product", "dbo.Products");
            DropForeignKey("dbo.OutputStockProducts", "output_stock_id_output_stock", "dbo.OutputStocks");
            DropForeignKey("dbo.InputStockProducts", "product_id_product", "dbo.Products");
            DropForeignKey("dbo.InputStockProducts", "input_stock_id_input_stock", "dbo.InputStocks");
            DropIndex("dbo.OutputStockProducts", new[] { "product_id_product" });
            DropIndex("dbo.OutputStockProducts", new[] { "output_stock_id_output_stock" });
            DropIndex("dbo.InputStockProducts", new[] { "product_id_product" });
            DropIndex("dbo.InputStockProducts", new[] { "input_stock_id_input_stock" });
            DropTable("dbo.OutputStockProducts");
            DropTable("dbo.OutputStocks");
            DropTable("dbo.Products");
            DropTable("dbo.InputStockProducts");
            DropTable("dbo.InputStocks");
        }
    }
}
