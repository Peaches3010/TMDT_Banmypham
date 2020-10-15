using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TMDT_Banmypham.Migrations
{
    public partial class Intial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appconfigs",
                columns: table => new
                {
                    Key = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appconfigs", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "Bài Viết",
                columns: table => new
                {
                    IDPost = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar", maxLength: 200, nullable: true),
                    Discription = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bài Viết", x => x.IDPost);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    IDCart = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    IDProduct = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.IDCart);
                });

            migrationBuilder.CreateTable(
                name: "Loại Sản Phẩm",
                columns: table => new
                {
                    IDCatalog = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loại Sản Phẩm", x => x.IDCatalog);
                });

            migrationBuilder.CreateTable(
                name: "Sản Phẩm",
                columns: table => new
                {
                    IDProduct = table.Column<int>(nullable: false),
                    Name = table.Column<string>(type: "nvarchar", maxLength: 200, nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    Status = table.Column<string>(nullable: false),
                    Stock = table.Column<int>(nullable: false, defaultValue: 0),
                    ViewCount = table.Column<int>(nullable: false, defaultValue: 0),
                    Date = table.Column<DateTime>(nullable: false),
                    CatalogIDCatalog = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sản Phẩm", x => x.IDProduct);
                    table.ForeignKey(
                        name: "FK_Sản Phẩm_Loại Sản Phẩm_CatalogIDCatalog",
                        column: x => x.CatalogIDCatalog,
                        principalTable: "Loại Sản Phẩm",
                        principalColumn: "IDCatalog",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sản Phẩm_Categories_IDProduct",
                        column: x => x.IDProduct,
                        principalTable: "Categories",
                        principalColumn: "IDCart",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: " Sản phẩm trong giỏ hàng",
                columns: table => new
                {
                    IDProduct = table.Column<int>(nullable: false),
                    IDCatalog = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ Sản phẩm trong giỏ hàng", x => new { x.IDCatalog, x.IDProduct });
                    table.ForeignKey(
                        name: "FK_ Sản phẩm trong giỏ hàng_Loại Sản Phẩm_IDCatalog",
                        column: x => x.IDCatalog,
                        principalTable: "Loại Sản Phẩm",
                        principalColumn: "IDCatalog",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ Sản phẩm trong giỏ hàng_Sản Phẩm_IDProduct",
                        column: x => x.IDProduct,
                        principalTable: "Sản Phẩm",
                        principalColumn: "IDProduct",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Thành Phần",
                columns: table => new
                {
                    IDIngredient = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rated = table.Column<int>(nullable: false),
                    Name = table.Column<int>(nullable: false),
                    DateWrite = table.Column<DateTime>(nullable: false),
                    Discription = table.Column<string>(nullable: true),
                    IDProduct = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Thành Phần", x => x.IDIngredient);
                    table.ForeignKey(
                        name: "FK_Thành Phần_Sản Phẩm_IDProduct",
                        column: x => x.IDProduct,
                        principalTable: "Sản Phẩm",
                        principalColumn: "IDProduct",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ Sản phẩm trong giỏ hàng_IDProduct",
                table: " Sản phẩm trong giỏ hàng",
                column: "IDProduct");

            migrationBuilder.CreateIndex(
                name: "IX_Sản Phẩm_CatalogIDCatalog",
                table: "Sản Phẩm",
                column: "CatalogIDCatalog");

            migrationBuilder.CreateIndex(
                name: "IX_Thành Phần_IDProduct",
                table: "Thành Phần",
                column: "IDProduct");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: " Sản phẩm trong giỏ hàng");

            migrationBuilder.DropTable(
                name: "Appconfigs");

            migrationBuilder.DropTable(
                name: "Bài Viết");

            migrationBuilder.DropTable(
                name: "Thành Phần");

            migrationBuilder.DropTable(
                name: "Sản Phẩm");

            migrationBuilder.DropTable(
                name: "Loại Sản Phẩm");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
