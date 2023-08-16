using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class migration_11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderProduct_Orders_ProductsId",
                table: "OrderProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderUser_Orders_UsersId",
                table: "OrderUser");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderUser_Users_UsersId1",
                table: "OrderUser");

            migrationBuilder.RenameColumn(
                name: "UsersId1",
                table: "OrderUser",
                newName: "UserId1");

            migrationBuilder.RenameColumn(
                name: "UsersId",
                table: "OrderUser",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderUser_UsersId1",
                table: "OrderUser",
                newName: "IX_OrderUser_UserId1");

            migrationBuilder.RenameColumn(
                name: "ProductsId",
                table: "OrderProduct",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderProduct_ProductsId",
                table: "OrderProduct",
                newName: "IX_OrderProduct_ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProduct_Orders_ProductId",
                table: "OrderProduct",
                column: "ProductId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderUser_Orders_UserId",
                table: "OrderUser",
                column: "UserId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderUser_Users_UserId1",
                table: "OrderUser",
                column: "UserId1",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderProduct_Orders_ProductId",
                table: "OrderProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderUser_Orders_UserId",
                table: "OrderUser");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderUser_Users_UserId1",
                table: "OrderUser");

            migrationBuilder.RenameColumn(
                name: "UserId1",
                table: "OrderUser",
                newName: "UsersId1");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "OrderUser",
                newName: "UsersId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderUser_UserId1",
                table: "OrderUser",
                newName: "IX_OrderUser_UsersId1");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "OrderProduct",
                newName: "ProductsId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderProduct_ProductId",
                table: "OrderProduct",
                newName: "IX_OrderProduct_ProductsId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProduct_Orders_ProductsId",
                table: "OrderProduct",
                column: "ProductsId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderUser_Orders_UsersId",
                table: "OrderUser",
                column: "UsersId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderUser_Users_UsersId1",
                table: "OrderUser",
                column: "UsersId1",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
