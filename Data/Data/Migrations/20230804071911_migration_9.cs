using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class migration_9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderProduct_Orders_OrdersId1",
                table: "OrderProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_UserId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_UserId",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Orders",
                newName: "UsersId");

            migrationBuilder.RenameColumn(
                name: "OrdersId1",
                table: "OrderProduct",
                newName: "ProductsId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderProduct_OrdersId1",
                table: "OrderProduct",
                newName: "IX_OrderProduct_ProductsId");

            migrationBuilder.AddColumn<int>(
                name: "OrdersId",
                table: "Products",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "OrderUser",
                columns: table => new
                {
                    UsersId = table.Column<int>(type: "integer", nullable: false),
                    UsersId1 = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderUser", x => new { x.UsersId, x.UsersId1 });
                    table.ForeignKey(
                        name: "FK_OrderUser_Orders_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderUser_Users_UsersId1",
                        column: x => x.UsersId1,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderUser_UsersId1",
                table: "OrderUser",
                column: "UsersId1");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProduct_Orders_ProductsId",
                table: "OrderProduct",
                column: "ProductsId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderProduct_Orders_ProductsId",
                table: "OrderProduct");

            migrationBuilder.DropTable(
                name: "OrderUser");

            migrationBuilder.DropColumn(
                name: "OrdersId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "UsersId",
                table: "Orders",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "ProductsId",
                table: "OrderProduct",
                newName: "OrdersId1");

            migrationBuilder.RenameIndex(
                name: "IX_OrderProduct_ProductsId",
                table: "OrderProduct",
                newName: "IX_OrderProduct_OrdersId1");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProduct_Orders_OrdersId1",
                table: "OrderProduct",
                column: "OrdersId1",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_UserId",
                table: "Orders",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
