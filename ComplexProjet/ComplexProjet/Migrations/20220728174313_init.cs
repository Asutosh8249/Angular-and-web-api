using Microsoft.EntityFrameworkCore.Migrations;

namespace ComplexProjet.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    productId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productName = table.Column<string>(maxLength: 20, nullable: false),
                    productDetails = table.Column<string>(maxLength: 2147483647, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.productId);
                });

            migrationBuilder.CreateTable(
                name: "feedbacks",
                columns: table => new
                {
                    feedbackId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    rating = table.Column<int>(nullable: false),
                    feedback = table.Column<string>(maxLength: 10, nullable: false),
                    productId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_feedbacks", x => x.feedbackId);
                    table.ForeignKey(
                        name: "FK_feedbacks_products_productId",
                        column: x => x.productId,
                        principalTable: "products",
                        principalColumn: "productId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    orderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    address = table.Column<string>(maxLength: 2147483647, nullable: false),
                    pincode = table.Column<int>(nullable: false),
                    productId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders", x => x.orderId);
                    table.ForeignKey(
                        name: "FK_orders_products_productId",
                        column: x => x.productId,
                        principalTable: "products",
                        principalColumn: "productId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "search",
                columns: table => new
                {
                    searchId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    searchByName = table.Column<string>(maxLength: 10, nullable: false),
                    searchByItem = table.Column<string>(maxLength: 10, nullable: false),
                    searchByPrice = table.Column<string>(maxLength: 10, nullable: false),
                    productId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_search", x => x.searchId);
                    table.ForeignKey(
                        name: "FK_search_products_productId",
                        column: x => x.productId,
                        principalTable: "products",
                        principalColumn: "productId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    userId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstName = table.Column<string>(maxLength: 10, nullable: false),
                    lastName = table.Column<string>(maxLength: 10, nullable: false),
                    phoneNumber = table.Column<long>(nullable: false),
                    email = table.Column<string>(maxLength: 30, nullable: false),
                    password = table.Column<string>(maxLength: 10, nullable: false),
                    productId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.userId);
                    table.ForeignKey(
                        name: "FK_users_products_productId",
                        column: x => x.productId,
                        principalTable: "products",
                        principalColumn: "productId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "log",
                columns: table => new
                {
                    loginId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    emailId = table.Column<string>(maxLength: 30, nullable: true),
                    password = table.Column<string>(maxLength: 10, nullable: true),
                    userId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_log", x => x.loginId);
                    table.ForeignKey(
                        name: "FK_log_users_userId",
                        column: x => x.userId,
                        principalTable: "users",
                        principalColumn: "userId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_feedbacks_productId",
                table: "feedbacks",
                column: "productId");

            migrationBuilder.CreateIndex(
                name: "IX_log_userId",
                table: "log",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_orders_productId",
                table: "orders",
                column: "productId");

            migrationBuilder.CreateIndex(
                name: "IX_search_productId",
                table: "search",
                column: "productId");

            migrationBuilder.CreateIndex(
                name: "IX_users_productId",
                table: "users",
                column: "productId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "feedbacks");

            migrationBuilder.DropTable(
                name: "log");

            migrationBuilder.DropTable(
                name: "orders");

            migrationBuilder.DropTable(
                name: "search");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "products");
        }
    }
}
