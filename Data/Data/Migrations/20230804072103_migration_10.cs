using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class migration_10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OrdersId",
                table: "Products",
                newName: "OrderId");

            migrationBuilder.RenameColumn(
                name: "UsersId",
                table: "Orders",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "ProductsId",
                table: "Orders",
                newName: "ProductId");

            migrationBuilder.AddColumn<int>(
                name: "BrandId",
                table: "Products",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Products",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BrandId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "Products",
                newName: "OrdersId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Orders",
                newName: "UsersId");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Orders",
                newName: "ProductsId");
        }
    }
}
