using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class migration_7 : Migration
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
                name: "FK_OrderUser_Users_UsersIdId",
                table: "OrderUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderUser",
                table: "OrderUser");

            migrationBuilder.DropIndex(
                name: "IX_OrderUser_UsersIdId",
                table: "OrderUser");

            migrationBuilder.RenameColumn(
                name: "UsersIdId",
                table: "OrderUser",
                newName: "OrdersId");

            migrationBuilder.RenameColumn(
                name: "ProductsId",
                table: "OrderProduct",
                newName: "OrdersId1");

            migrationBuilder.RenameIndex(
                name: "IX_OrderProduct_ProductsId",
                table: "OrderProduct",
                newName: "IX_OrderProduct_OrdersId1");

            migrationBuilder.AddColumn<int>(
                name: "ProductsId",
                table: "Orders",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderUser",
                table: "OrderUser",
                columns: new[] { "OrdersId", "UsersId" });

            migrationBuilder.CreateIndex(
                name: "IX_OrderUser_UsersId",
                table: "OrderUser",
                column: "UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProduct_Orders_OrdersId1",
                table: "OrderProduct",
                column: "OrdersId1",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderUser_Orders_OrdersId",
                table: "OrderUser",
                column: "OrdersId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderUser_Users_UsersId",
                table: "OrderUser",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderProduct_Orders_OrdersId1",
                table: "OrderProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderUser_Orders_OrdersId",
                table: "OrderUser");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderUser_Users_UsersId",
                table: "OrderUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderUser",
                table: "OrderUser");

            migrationBuilder.DropIndex(
                name: "IX_OrderUser_UsersId",
                table: "OrderUser");

            migrationBuilder.DropColumn(
                name: "ProductsId",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "OrdersId",
                table: "OrderUser",
                newName: "UsersIdId");

            migrationBuilder.RenameColumn(
                name: "OrdersId1",
                table: "OrderProduct",
                newName: "ProductsId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderProduct_OrdersId1",
                table: "OrderProduct",
                newName: "IX_OrderProduct_ProductsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderUser",
                table: "OrderUser",
                columns: new[] { "UsersId", "UsersIdId" });

            migrationBuilder.CreateIndex(
                name: "IX_OrderUser_UsersIdId",
                table: "OrderUser",
                column: "UsersIdId");

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
                name: "FK_OrderUser_Users_UsersIdId",
                table: "OrderUser",
                column: "UsersIdId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
