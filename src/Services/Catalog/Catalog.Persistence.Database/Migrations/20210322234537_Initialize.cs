﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalog.Persistence.Database.Migrations
{
    public partial class Initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Catalog");

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "Catalog",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                schema: "Catalog",
                columns: table => new
                {
                    ProductInStockId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    Stock = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.ProductInStockId);
                    table.ForeignKey(
                        name: "FK_Stocks_Products_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "Catalog",
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Description for product 1", "Product 1", 636m },
                    { 73, "Description for product 73", "Product 73", 295m },
                    { 72, "Description for product 72", "Product 72", 204m },
                    { 71, "Description for product 71", "Product 71", 710m },
                    { 70, "Description for product 70", "Product 70", 132m },
                    { 69, "Description for product 69", "Product 69", 481m },
                    { 68, "Description for product 68", "Product 68", 126m },
                    { 67, "Description for product 67", "Product 67", 926m },
                    { 66, "Description for product 66", "Product 66", 966m },
                    { 65, "Description for product 65", "Product 65", 183m },
                    { 64, "Description for product 64", "Product 64", 238m },
                    { 63, "Description for product 63", "Product 63", 523m },
                    { 62, "Description for product 62", "Product 62", 712m },
                    { 61, "Description for product 61", "Product 61", 559m },
                    { 60, "Description for product 60", "Product 60", 361m },
                    { 59, "Description for product 59", "Product 59", 800m },
                    { 58, "Description for product 58", "Product 58", 985m },
                    { 57, "Description for product 57", "Product 57", 284m },
                    { 56, "Description for product 56", "Product 56", 902m },
                    { 55, "Description for product 55", "Product 55", 102m },
                    { 54, "Description for product 54", "Product 54", 913m },
                    { 53, "Description for product 53", "Product 53", 228m },
                    { 74, "Description for product 74", "Product 74", 296m },
                    { 52, "Description for product 52", "Product 52", 512m },
                    { 75, "Description for product 75", "Product 75", 386m },
                    { 77, "Description for product 77", "Product 77", 524m },
                    { 98, "Description for product 98", "Product 98", 170m },
                    { 97, "Description for product 97", "Product 97", 353m },
                    { 96, "Description for product 96", "Product 96", 680m },
                    { 95, "Description for product 95", "Product 95", 723m },
                    { 94, "Description for product 94", "Product 94", 153m },
                    { 93, "Description for product 93", "Product 93", 282m },
                    { 92, "Description for product 92", "Product 92", 555m },
                    { 91, "Description for product 91", "Product 91", 854m },
                    { 90, "Description for product 90", "Product 90", 503m },
                    { 89, "Description for product 89", "Product 89", 184m },
                    { 88, "Description for product 88", "Product 88", 917m },
                    { 87, "Description for product 87", "Product 87", 655m },
                    { 86, "Description for product 86", "Product 86", 915m },
                    { 85, "Description for product 85", "Product 85", 472m },
                    { 84, "Description for product 84", "Product 84", 226m },
                    { 83, "Description for product 83", "Product 83", 918m },
                    { 82, "Description for product 82", "Product 82", 471m },
                    { 81, "Description for product 81", "Product 81", 449m },
                    { 80, "Description for product 80", "Product 80", 196m },
                    { 79, "Description for product 79", "Product 79", 109m },
                    { 78, "Description for product 78", "Product 78", 736m },
                    { 76, "Description for product 76", "Product 76", 393m },
                    { 51, "Description for product 51", "Product 51", 705m },
                    { 50, "Description for product 50", "Product 50", 131m },
                    { 49, "Description for product 49", "Product 49", 147m },
                    { 22, "Description for product 22", "Product 22", 733m },
                    { 21, "Description for product 21", "Product 21", 170m },
                    { 20, "Description for product 20", "Product 20", 679m },
                    { 19, "Description for product 19", "Product 19", 479m },
                    { 18, "Description for product 18", "Product 18", 609m },
                    { 17, "Description for product 17", "Product 17", 187m },
                    { 16, "Description for product 16", "Product 16", 251m },
                    { 15, "Description for product 15", "Product 15", 172m },
                    { 14, "Description for product 14", "Product 14", 787m },
                    { 13, "Description for product 13", "Product 13", 214m },
                    { 12, "Description for product 12", "Product 12", 757m },
                    { 11, "Description for product 11", "Product 11", 749m },
                    { 10, "Description for product 10", "Product 10", 511m },
                    { 9, "Description for product 9", "Product 9", 316m },
                    { 8, "Description for product 8", "Product 8", 681m },
                    { 7, "Description for product 7", "Product 7", 678m },
                    { 6, "Description for product 6", "Product 6", 525m },
                    { 5, "Description for product 5", "Product 5", 951m },
                    { 4, "Description for product 4", "Product 4", 177m },
                    { 3, "Description for product 3", "Product 3", 292m },
                    { 2, "Description for product 2", "Product 2", 216m },
                    { 23, "Description for product 23", "Product 23", 932m },
                    { 24, "Description for product 24", "Product 24", 306m },
                    { 25, "Description for product 25", "Product 25", 377m },
                    { 26, "Description for product 26", "Product 26", 690m },
                    { 48, "Description for product 48", "Product 48", 594m },
                    { 47, "Description for product 47", "Product 47", 340m },
                    { 46, "Description for product 46", "Product 46", 281m },
                    { 45, "Description for product 45", "Product 45", 297m },
                    { 44, "Description for product 44", "Product 44", 295m },
                    { 43, "Description for product 43", "Product 43", 309m },
                    { 42, "Description for product 42", "Product 42", 776m },
                    { 41, "Description for product 41", "Product 41", 393m },
                    { 40, "Description for product 40", "Product 40", 282m },
                    { 39, "Description for product 39", "Product 39", 414m },
                    { 99, "Description for product 99", "Product 99", 211m },
                    { 38, "Description for product 38", "Product 38", 983m },
                    { 36, "Description for product 36", "Product 36", 139m },
                    { 35, "Description for product 35", "Product 35", 405m },
                    { 34, "Description for product 34", "Product 34", 187m },
                    { 33, "Description for product 33", "Product 33", 830m },
                    { 32, "Description for product 32", "Product 32", 783m },
                    { 31, "Description for product 31", "Product 31", 427m },
                    { 30, "Description for product 30", "Product 30", 177m },
                    { 29, "Description for product 29", "Product 29", 257m },
                    { 28, "Description for product 28", "Product 28", 966m },
                    { 27, "Description for product 27", "Product 27", 965m },
                    { 37, "Description for product 37", "Product 37", 540m },
                    { 100, "Description for product 100", "Product 100", 331m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Stocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 1, 1, 0 },
                    { 73, 73, 18 },
                    { 72, 72, 13 },
                    { 71, 71, 2 },
                    { 70, 70, 2 },
                    { 69, 69, 15 },
                    { 68, 68, 4 },
                    { 67, 67, 16 },
                    { 66, 66, 1 },
                    { 65, 65, 12 },
                    { 64, 64, 6 },
                    { 63, 63, 7 },
                    { 62, 62, 1 },
                    { 61, 61, 15 },
                    { 60, 60, 15 },
                    { 59, 59, 19 },
                    { 58, 58, 8 },
                    { 57, 57, 0 },
                    { 56, 56, 6 },
                    { 55, 55, 10 },
                    { 54, 54, 11 },
                    { 53, 53, 15 },
                    { 74, 74, 18 },
                    { 52, 52, 8 },
                    { 75, 75, 5 },
                    { 77, 77, 6 },
                    { 98, 98, 0 },
                    { 97, 97, 11 },
                    { 96, 96, 2 },
                    { 95, 95, 3 },
                    { 94, 94, 2 },
                    { 93, 93, 9 },
                    { 92, 92, 11 },
                    { 91, 91, 15 },
                    { 90, 90, 11 },
                    { 89, 89, 19 },
                    { 88, 88, 11 },
                    { 87, 87, 15 },
                    { 86, 86, 19 },
                    { 85, 85, 4 },
                    { 84, 84, 5 },
                    { 83, 83, 1 },
                    { 82, 82, 7 },
                    { 81, 81, 15 },
                    { 80, 80, 12 },
                    { 79, 79, 11 },
                    { 78, 78, 19 },
                    { 76, 76, 16 },
                    { 51, 51, 2 },
                    { 50, 50, 4 },
                    { 49, 49, 1 },
                    { 22, 22, 14 },
                    { 21, 21, 15 },
                    { 20, 20, 10 },
                    { 19, 19, 17 },
                    { 18, 18, 17 },
                    { 17, 17, 2 },
                    { 16, 16, 2 },
                    { 15, 15, 19 },
                    { 14, 14, 14 },
                    { 13, 13, 13 },
                    { 12, 12, 19 },
                    { 11, 11, 12 },
                    { 10, 10, 1 },
                    { 9, 9, 14 },
                    { 8, 8, 17 },
                    { 7, 7, 4 },
                    { 6, 6, 9 },
                    { 5, 5, 12 },
                    { 4, 4, 8 },
                    { 3, 3, 14 },
                    { 2, 2, 9 },
                    { 23, 23, 8 },
                    { 24, 24, 6 },
                    { 25, 25, 9 },
                    { 26, 26, 17 },
                    { 48, 48, 6 },
                    { 47, 47, 1 },
                    { 46, 46, 16 },
                    { 45, 45, 14 },
                    { 44, 44, 9 },
                    { 43, 43, 7 },
                    { 42, 42, 18 },
                    { 41, 41, 4 },
                    { 40, 40, 18 },
                    { 39, 39, 18 },
                    { 99, 99, 16 },
                    { 38, 38, 8 },
                    { 36, 36, 16 },
                    { 35, 35, 18 },
                    { 34, 34, 9 },
                    { 33, 33, 2 },
                    { 32, 32, 10 },
                    { 31, 31, 8 },
                    { 30, 30, 7 },
                    { 29, 29, 10 },
                    { 28, 28, 2 },
                    { 27, 27, 14 },
                    { 37, 37, 19 },
                    { 100, 100, 12 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ProductId",
                schema: "Catalog",
                table: "Stocks",
                column: "ProductId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stocks",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "Products",
                schema: "Catalog");
        }
    }
}
